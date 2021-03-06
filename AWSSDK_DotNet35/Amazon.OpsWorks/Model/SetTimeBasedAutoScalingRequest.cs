/*
 * Copyright 2010-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.OpsWorks.Model
{
    /// <summary>
    /// Container for the parameters to the SetTimeBasedAutoScaling operation.
    /// <para>Specify the time-based auto scaling configuration for a specified instance. For more information, see <a
    /// href="http://docs.aws.amazon.com/opsworks/latest/userguide/workinginstances-autoscaling.html" >Managing Load with Time-based and Load-based
    /// Instances</a> .</para>
    /// </summary>
    public partial class SetTimeBasedAutoScalingRequest : AmazonWebServiceRequest
    {
        private string instanceId;
        private WeeklyAutoScalingSchedule autoScalingSchedule;

        /// <summary>
        /// The instance ID.
        ///  
        /// </summary>
        public string InstanceId
        {
            get { return this.instanceId; }
            set { this.instanceId = value; }
        }

        // Check to see if InstanceId property is set
        internal bool IsSetInstanceId()
        {
            return this.instanceId != null;
        }

        /// <summary>
        /// An <c>AutoScalingSchedule</c> with the instance schedule.
        ///  
        /// </summary>
        public WeeklyAutoScalingSchedule AutoScalingSchedule
        {
            get { return this.autoScalingSchedule; }
            set { this.autoScalingSchedule = value; }
        }

        // Check to see if AutoScalingSchedule property is set
        internal bool IsSetAutoScalingSchedule()
        {
            return this.autoScalingSchedule != null;
        }

    }
}
    
