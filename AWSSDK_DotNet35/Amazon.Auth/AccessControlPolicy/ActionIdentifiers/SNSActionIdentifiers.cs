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
using System.Text;

namespace Amazon.Auth.AccessControlPolicy.ActionIdentifiers
{
    /// <summary>
    /// The available AWS access control policy actions for Amazon SNS.
    /// </summary>
    /// <see cref="Amazon.Auth.AccessControlPolicy.Statement.Actions"/>
    public static class SNSActionIdentifiers
    {
        public static readonly ActionIdentifier AllSNSActions = new ActionIdentifier("sns:*");

        public static readonly ActionIdentifier AddPermission = new ActionIdentifier("sns:AddPermission");
        public static readonly ActionIdentifier ConfirmSubscription = new ActionIdentifier("sns:ConfirmSubscription");
        public static readonly ActionIdentifier CreateTopic = new ActionIdentifier("sns:CreateTopic");
        public static readonly ActionIdentifier DeleteTopic = new ActionIdentifier("sns:DeleteTopic");
        public static readonly ActionIdentifier GetTopicAttributes = new ActionIdentifier("sns:GetTopicAttributes");
        public static readonly ActionIdentifier ListSubscriptions = new ActionIdentifier("sns:ListSubscriptions");
        public static readonly ActionIdentifier ListSubscriptionsByTopic = new ActionIdentifier("sns:ListSubscriptionsByTopic");
        public static readonly ActionIdentifier ListTopics = new ActionIdentifier("sns:ListTopics");
        public static readonly ActionIdentifier Publish = new ActionIdentifier("sns:Publish");
        public static readonly ActionIdentifier RemovePermission = new ActionIdentifier("sns:RemovePermission");
        public static readonly ActionIdentifier SetTopicAttributes = new ActionIdentifier("sns:SetTopicAttributes");
        public static readonly ActionIdentifier Subscribe = new ActionIdentifier("sns:Subscribe");
        public static readonly ActionIdentifier Unsubscribe = new ActionIdentifier("sns:Unsubscribe");
    }
}
