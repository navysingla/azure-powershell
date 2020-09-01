// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Commands.Synapse.Models
{
    using global::Azure.Analytics.Synapse.Artifacts.Models;
    using Microsoft.Rest;
    using Microsoft.Rest.Serialization;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Oracle Service Cloud linked service.
    /// </summary>
    [Newtonsoft.Json.JsonObject("OracleServiceCloud")]
    [Rest.Serialization.JsonTransformation]
    public partial class PSOracleServiceCloudLinkedService : PSLinkedService
    {
        /// <summary>
        /// Initializes a new instance of the PSOracleServiceCloudLinkedService
        /// class.
        /// </summary>
        public PSOracleServiceCloudLinkedService()
        {
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the URL of the Oracle Service Cloud instance.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.host")]
        public object Host { get; set; }

        /// <summary>
        /// Gets or sets the user name that you use to access Oracle Service
        /// Cloud server.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.username")]
        public object Username { get; set; }

        /// <summary>
        /// Gets or sets the password corresponding to the user name that you
        /// provided in the username key.
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.password")]
        public SecretBase Password { get; set; }

        /// <summary>
        /// Gets or sets specifies whether the data source endpoints are
        /// encrypted using HTTPS. The default value is true. Type: boolean (or
        /// Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useEncryptedEndpoints")]
        public object UseEncryptedEndpoints { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to require the host name in the
        /// server's certificate to match the host name of the server when
        /// connecting over SSL. The default value is true. Type: boolean (or
        /// Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.useHostVerification")]
        public object UseHostVerification { get; set; }

        /// <summary>
        /// Gets or sets specifies whether to verify the identity of the server
        /// when connecting over SSL. The default value is true. Type: boolean
        /// (or Expression with resultType boolean).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.usePeerVerification")]
        public object UsePeerVerification { get; set; }

        /// <summary>
        /// Gets or sets the encrypted credential used for authentication.
        /// Credentials are encrypted using the integration runtime credential
        /// manager. Type: string (or Expression with resultType string).
        /// </summary>
        [JsonProperty(PropertyName = "typeProperties.encryptedCredential")]
        public object EncryptedCredential { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
            if (Host == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Host");
            }
            if (Username == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Username");
            }
            if (Password == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Password");
            }
        }

        public override LinkedService ToSdkObject()
        {
            var linkedService = new OracleServiceCloudLinkedService(this.Host, this.Username, this.Password);
            linkedService.UseEncryptedEndpoints = this.UseEncryptedEndpoints;
            linkedService.UseHostVerification = this.UseHostVerification;
            linkedService.UsePeerVerification = this.UsePeerVerification;
            linkedService.EncryptedCredential = this.EncryptedCredential;
            SetProperties(linkedService);
            return linkedService;
        }
    }
}

