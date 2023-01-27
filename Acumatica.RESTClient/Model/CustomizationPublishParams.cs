using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Acumatica.RESTClient.Model
{
    /// <summary>
    /// CustomizationImport
    /// </summary>
    [DataContract]
    public partial class CustomizationPublishParams
    {
        public CustomizationPublishParams()
        {
        }


        [DataMember(Name= "isMergeWithExistingPackages", EmitDefaultValue=false)]
        public bool IsMergeWithExistingPackages { get; set; }

        [DataMember(Name = "isOnlyValidation", EmitDefaultValue = false)]
        public bool IsOnlyValidation { get; set; }

        [DataMember(Name = "isOnlyDbUpdates", EmitDefaultValue = false)]
        public bool IsOnlyDbUpdates { get; set; }

        [DataMember(Name = "isReplayPreviouslyExecutedScripts", EmitDefaultValue = false)]
        public bool IsReplayPreviouslyExecutedScripts { get; set; }

        [DataMember(Name = "projectNames", EmitDefaultValue = false)]
        public List<string> ProjectNames { get; set; }

        [DataMember(Name = "tenantMode", EmitDefaultValue = false)]
        public string TenantMode { get; set; }

    }
}
