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

namespace Amazon.EC2.Model
{
    /// <summary>Instance Network Interface
    /// </summary>
    public class InstanceNetworkInterface
    {
        
        private string networkInterfaceId;
        private string subnetId;
        private string vpcId;
        private string description;
        private string ownerId;
        private NetworkInterfaceStatus status;
        private string privateIpAddress;
        private string privateDnsName;
        private bool? sourceDestCheck;
        private List<GroupIdentifier> groups = new List<GroupIdentifier>();
        private InstanceNetworkInterfaceAttachment attachment;
        private InstanceNetworkInterfaceAssociation association;
        private List<InstancePrivateIpAddress> privateIpAddresses = new List<InstancePrivateIpAddress>();

        public string NetworkInterfaceId
        {
            get { return this.networkInterfaceId; }
            set { this.networkInterfaceId = value; }
        }

        // Check to see if NetworkInterfaceId property is set
        internal bool IsSetNetworkInterfaceId()
        {
            return this.networkInterfaceId != null;
        }
        public string SubnetId
        {
            get { return this.subnetId; }
            set { this.subnetId = value; }
        }

        // Check to see if SubnetId property is set
        internal bool IsSetSubnetId()
        {
            return this.subnetId != null;
        }
        public string VpcId
        {
            get { return this.vpcId; }
            set { this.vpcId = value; }
        }

        // Check to see if VpcId property is set
        internal bool IsSetVpcId()
        {
            return this.vpcId != null;
        }
        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        // Check to see if Description property is set
        internal bool IsSetDescription()
        {
            return this.description != null;
        }
        public string OwnerId
        {
            get { return this.ownerId; }
            set { this.ownerId = value; }
        }

        // Check to see if OwnerId property is set
        internal bool IsSetOwnerId()
        {
            return this.ownerId != null;
        }
        public NetworkInterfaceStatus Status
        {
            get { return this.status; }
            set { this.status = value; }
        }

        // Check to see if Status property is set
        internal bool IsSetStatus()
        {
            return this.status != null;
        }
        public string PrivateIpAddress
        {
            get { return this.privateIpAddress; }
            set { this.privateIpAddress = value; }
        }

        // Check to see if PrivateIpAddress property is set
        internal bool IsSetPrivateIpAddress()
        {
            return this.privateIpAddress != null;
        }
        public string PrivateDnsName
        {
            get { return this.privateDnsName; }
            set { this.privateDnsName = value; }
        }

        // Check to see if PrivateDnsName property is set
        internal bool IsSetPrivateDnsName()
        {
            return this.privateDnsName != null;
        }
        public bool SourceDestCheck
        {
            get { return this.sourceDestCheck ?? default(bool); }
            set { this.sourceDestCheck = value; }
        }

        // Check to see if SourceDestCheck property is set
        internal bool IsSetSourceDestCheck()
        {
            return this.sourceDestCheck.HasValue;
        }
        public List<GroupIdentifier> Groups
        {
            get { return this.groups; }
            set { this.groups = value; }
        }

        // Check to see if Groups property is set
        internal bool IsSetGroups()
        {
            return this.groups.Count > 0;
        }
        public InstanceNetworkInterfaceAttachment Attachment
        {
            get { return this.attachment; }
            set { this.attachment = value; }
        }

        // Check to see if Attachment property is set
        internal bool IsSetAttachment()
        {
            return this.attachment != null;
        }
        public InstanceNetworkInterfaceAssociation Association
        {
            get { return this.association; }
            set { this.association = value; }
        }

        // Check to see if Association property is set
        internal bool IsSetAssociation()
        {
            return this.association != null;
        }
        public List<InstancePrivateIpAddress> PrivateIpAddresses
        {
            get { return this.privateIpAddresses; }
            set { this.privateIpAddresses = value; }
        }

        // Check to see if PrivateIpAddresses property is set
        internal bool IsSetPrivateIpAddresses()
        {
            return this.privateIpAddresses.Count > 0;
        }
    }
}
