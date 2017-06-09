﻿// 
// Conflict.cs
// 
// Author:
//     Jim Borden  <jim.borden@couchbase.com>
// 
// Copyright (c) 2017 Couchbase, Inc All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// 
namespace Couchbase.Lite
{
    /// <summary>
    /// An enum representing the operation type that caused a <see cref="Conflict"/>
    /// </summary>
    public enum OperationType
    {
        /// <summary>
        /// A local write operation to a database
        /// </summary>
        DatabaseWrite,
        /// <summary>
        /// A push replication
        /// </summary>
        PushReplication,
        /// <summary>
        /// A pull replication
        /// </summary>
        PullReplication
    }

    /// <summary>
    /// A class representing a conflict situation.  A conflict occurs as part of a distributed system
    /// where two offline nodes modify the same data at the same time.  This class serves to give
    /// information on such situations so that they can be resolved correctly.
    /// </summary>
    public sealed class Conflict
    {
        #region Properties

        /// <summary>
        /// Gets the state of the document before any edits were made
        /// </summary>
        public ReadOnlyDocument CommonAncestor { get; }

        /// <summary>
        /// Gets the type of operation that caused the conflict
        /// </summary>
        public OperationType OperationType { get; }

        /// <summary>
        /// Gets the version of the document that is already existing
        /// </summary>
        public ReadOnlyDocument Source { get; }

        /// <summary>
        /// Gets the version of the document that is attempting to be
        /// written but cannot due to an existing version
        /// </summary>
        public ReadOnlyDocument Target { get; }

        #endregion

        #region Constructors

        internal Conflict(ReadOnlyDocument source, ReadOnlyDocument target, ReadOnlyDocument commonAncestor,
            OperationType opType)
        {
            Source = source;
            Target = target;
            CommonAncestor = commonAncestor;
            OperationType = opType;
        }

        #endregion
    }
}