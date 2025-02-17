﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

using Acumatica.Auth.Api;
using Acumatica.Default_20_200_001.Api;

using static Acumatica.Auth.Api.AuthApi;

namespace AcumaticaRestApiExample
{
    internal class OAuthAuthCodeExample
    {
        public static void Example(string siteURL, string clientSecret, string clientID, string redirectUrl)
        {
            var authApi = new AuthApi(siteURL, 
                requestInterceptor: RequestLogger.LogRequest, responseInterceptor: RequestLogger.LogResponse);
            var url = authApi.Authorize(
                clientID,
                clientSecret,
                 redirectUrl,
                 OAuthScope.API | OAuthScope.OfflineAccess
                );
            OpenUrl(url);
            var code = ReadCodeFromRedirectURL(redirectUrl);

            var configuration = authApi.ReceiveAccessTokenAuthCode(
                clientID,
                clientSecret,
                redirectUrl,
                code);

            foreach (var account in new AccountApi(configuration).GetList(top: 5))
            {
                Console.WriteLine(account.Description.Value);
            }
            authApi.TryLogout();

        }

        private static string ReadCodeFromRedirectURL(string url)
        {
            HttpListener listener = new HttpListener();

            listener.Prefixes.Add(url);
            try
            {
                listener.Start();

                HttpListenerContext context = listener.GetContext();

                HttpListenerRequest request = context.Request;
                var rawUrl = request.RawUrl;
                const string codeParametrIdentifier = "?code=";
                var codewithgarbage = rawUrl.Substring(rawUrl.IndexOf(codeParametrIdentifier) + codeParametrIdentifier.Length);
                var purecode = codewithgarbage.Substring(0, codewithgarbage.IndexOf("&"));
                return purecode;
            }
            finally
            {
                listener.Stop();
            }
        }

        private static void OpenUrl(string url)
        {
            try
            {
                Process.Start(url);
            }
            catch
            {
                // hack because of this: https://github.com/dotnet/corefx/issues/10361
                if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                {
                    url = url.Replace("&", "^&");
                    Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux))
                {
                    Process.Start("xdg-open", url);
                }
                else if (RuntimeInformation.IsOSPlatform(OSPlatform.OSX))
                {
                    Process.Start("open", url);
                }
                else
                {
                    throw;
                }
            }
        }
    }
}
