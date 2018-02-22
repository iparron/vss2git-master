﻿/* Copyright 2009 HPDI, LLC
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System.IO;

namespace Hpdi.VssPhysicalLib
{
    /// <summary>
    /// Base class for VSS records.
    /// </summary>
    /// <author>Trevor Robinson</author>
    public abstract class VssRecord
    {
        public abstract string Signature { get; }

        protected RecordHeader header;
        public RecordHeader Header
        {
            get { return header; }
        }

        public virtual void Read(BufferReader reader, RecordHeader header)
        {
            this.header = header;
        }

        public abstract void Dump(TextWriter writer);
    }
}
