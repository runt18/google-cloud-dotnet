﻿// Copyright 2016 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Api.Gax;

namespace Google.Datastore.V1
{
    public partial class PartitionId
    {
        /// <summary>
        /// Creates a partition ID from the given project ID and namespace ID.
        /// </summary>
        /// <param name="projectId">The project ID of the partition. Must not be null.</param>
        /// <param name="namespaceId">The namespace ID of the partition. Must not be null.</param>
        public PartitionId(string projectId, string namespaceId = "") : this()
        {
            // TODO: Validate that the project ID is non-empty?
            // TODO: Validate the IDs against a regex?
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            NamespaceId = GaxPreconditions.CheckNotNull(namespaceId, nameof(namespaceId));
        }
    }
}
