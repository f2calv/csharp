// Code generated by Microsoft (R) AutoRest Code Generator 1.1.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace k8s.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ResourceMetricSource indicates how to scale on a resource metric known
    /// to Kubernetes, as specified in requests and limits, describing each pod
    /// in the current scale target (e.g. CPU or memory).  The values will be
    /// averaged together before being compared to the target.  Such metrics
    /// are built in to Kubernetes, and have special scaling options on top of
    /// those available to normal per-pod metrics using the "pods" source.
    /// Only one "target" type should be set.
    /// </summary>
    public partial class V2alpha1ResourceMetricSource
    {
        /// <summary>
        /// Initializes a new instance of the V2alpha1ResourceMetricSource
        /// class.
        /// </summary>
        public V2alpha1ResourceMetricSource()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the V2alpha1ResourceMetricSource
        /// class.
        /// </summary>
        /// <param name="name">name is the name of the resource in
        /// question.</param>
        /// <param name="targetAverageUtilization">targetAverageUtilization is
        /// the target value of the average of the resource metric across all
        /// relevant pods, represented as a percentage of the requested value
        /// of the resource for the pods.</param>
        /// <param name="targetAverageValue">targetAverageValue is the the
        /// target value of the average of the resource metric across all
        /// relevant pods, as a raw value (instead of as a percentage of the
        /// request), similar to the "pods" metric source type.</param>
        public V2alpha1ResourceMetricSource(string name, int? targetAverageUtilization = default(int?), string targetAverageValue = default(string))
        {
            Name = name;
            TargetAverageUtilization = targetAverageUtilization;
            TargetAverageValue = targetAverageValue;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets name is the name of the resource in question.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets targetAverageUtilization is the target value of the
        /// average of the resource metric across all relevant pods,
        /// represented as a percentage of the requested value of the resource
        /// for the pods.
        /// </summary>
        [JsonProperty(PropertyName = "targetAverageUtilization")]
        public int? TargetAverageUtilization { get; set; }

        /// <summary>
        /// Gets or sets targetAverageValue is the the target value of the
        /// average of the resource metric across all relevant pods, as a raw
        /// value (instead of as a percentage of the request), similar to the
        /// "pods" metric source type.
        /// </summary>
        [JsonProperty(PropertyName = "targetAverageValue")]
        public string TargetAverageValue { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new ValidationException(ValidationRules.CannotBeNull, "Name");
            }
        }
    }
}
