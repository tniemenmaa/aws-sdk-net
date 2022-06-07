/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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

/*
 * Do not modify this file. This file is generated from the ce-2017-10-25.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.CostExplorer.Model
{
    /// <summary>
    /// Container for the parameters to the UpdateCostAllocationTagsStatus operation.
    /// Updates status for cost allocation tags in bulk, with maximum batch size of 20. If
    /// the tag status that's updated is the same as the existing tag status, the request
    /// doesn't fail. Instead, it doesn't have any effect on the tag status (for example,
    /// activating the active tag).
    /// </summary>
    public partial class UpdateCostAllocationTagsStatusRequest : AmazonCostExplorerRequest
    {
        private List<CostAllocationTagStatusEntry> _costAllocationTagsStatus = new List<CostAllocationTagStatusEntry>();

        /// <summary>
        /// Gets and sets the property CostAllocationTagsStatus. 
        /// <para>
        /// The list of <code>CostAllocationTagStatusEntry</code> objects that are used to update
        /// cost allocation tags status for this request. 
        /// </para>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=20)]
        public List<CostAllocationTagStatusEntry> CostAllocationTagsStatus
        {
            get { return this._costAllocationTagsStatus; }
            set { this._costAllocationTagsStatus = value; }
        }

        // Check to see if CostAllocationTagsStatus property is set
        internal bool IsSetCostAllocationTagsStatus()
        {
            return this._costAllocationTagsStatus != null && this._costAllocationTagsStatus.Count > 0; 
        }

    }
}