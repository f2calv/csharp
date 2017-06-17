// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents a Rados Block Device mount that lasts the lifetime of a pod.
    /// RBD volumes support ownership management and SELinux relabeling.
    /// </summary>
    public partial class V1RBDVolumeSource
    {
        /// <summary>
        /// Initializes a new instance of the V1RBDVolumeSource class.
        /// </summary>
        public V1RBDVolumeSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V1RBDVolumeSource class.
        /// </summary>
        /// <param name="image">The rados image name. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</param>
        /// <param name="monitors">A collection of Ceph monitors. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</param>
        /// <param name="fsType">Filesystem type of the volume that you want to
        /// mount. Tip: Ensure that the filesystem type is supported by the
        /// host operating system. Examples: "ext4", "xfs", "ntfs". Implicitly
        /// inferred to be "ext4" if unspecified. More info:
        /// http://kubernetes.io/docs/user-guide/volumes#rbd</param>
        /// <param name="keyring">Keyring is the path to key ring for RBDUser.
        /// Default is /etc/ceph/keyring. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</param>
        /// <param name="pool">The rados pool name. Default is rbd. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it.</param>
        /// <param name="readOnlyProperty">ReadOnly here will force the
        /// ReadOnly setting in VolumeMounts. Defaults to false. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</param>
        /// <param name="secretRef">SecretRef is name of the authentication
        /// secret for RBDUser. If provided overrides keyring. Default is nil.
        /// More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</param>
        /// <param name="user">The rados user name. Default is admin. More
        /// info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it</param>
        public V1RBDVolumeSource(string image, IList<string> monitors, string fsType = default(string), string keyring = default(string), string pool = default(string), bool? readOnlyProperty = default(bool?), V1LocalObjectReference secretRef = default(V1LocalObjectReference), string user = default(string))
        {
            FsType = fsType;
            Image = image;
            Keyring = keyring;
            Monitors = monitors;
            Pool = pool;
            ReadOnlyProperty = readOnlyProperty;
            SecretRef = secretRef;
            User = user;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets filesystem type of the volume that you want to mount.
        /// Tip: Ensure that the filesystem type is supported by the host
        /// operating system. Examples: "ext4", "xfs", "ntfs". Implicitly
        /// inferred to be "ext4" if unspecified. More info:
        /// http://kubernetes.io/docs/user-guide/volumes#rbd
        /// </summary>
        [JsonProperty(PropertyName = "fsType")]
        public string FsType { get; set; }

        /// <summary>
        /// Gets or sets the rados image name. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty(PropertyName = "image")]
        public string Image { get; set; }

        /// <summary>
        /// Gets or sets keyring is the path to key ring for RBDUser. Default
        /// is /etc/ceph/keyring. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty(PropertyName = "keyring")]
        public string Keyring { get; set; }

        /// <summary>
        /// Gets or sets a collection of Ceph monitors. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty(PropertyName = "monitors")]
        public IList<string> Monitors { get; set; }

        /// <summary>
        /// Gets or sets the rados pool name. Default is rbd. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it.
        /// </summary>
        [JsonProperty(PropertyName = "pool")]
        public string Pool { get; set; }

        /// <summary>
        /// Gets or sets readOnly here will force the ReadOnly setting in
        /// VolumeMounts. Defaults to false. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty(PropertyName = "readOnly")]
        public bool? ReadOnlyProperty { get; set; }

        /// <summary>
        /// Gets or sets secretRef is name of the authentication secret for
        /// RBDUser. If provided overrides keyring. Default is nil. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty(PropertyName = "secretRef")]
        public V1LocalObjectReference SecretRef { get; set; }

        /// <summary>
        /// Gets or sets the rados user name. Default is admin. More info:
        /// http://releases.k8s.io/HEAD/examples/volumes/rbd/README.md#how-to-use-it
        /// </summary>
        [JsonProperty(PropertyName = "user")]
        public string User { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Image == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Image");
            }
            if (Monitors == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Monitors");
            }
        }
    }
}
