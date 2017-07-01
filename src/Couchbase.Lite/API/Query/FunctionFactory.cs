﻿// 
// FunctionFactory.cs
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
using System;
using Couchbase.Lite.Internal.Query;

namespace Couchbase.Lite.Query
{
    public static class FunctionFactory
    {
        #region Public Methods

        public static IFunction Avg(object expression)
        {
            return new Function("AVG()", expression);
        }

        public static IFunction Count(object expression)
        {
            return new Function("COUNT()", expression);
        }

        public static IFunction Max(object expression)
        {
            return new Function("MAX()", expression);
        }

        public static IFunction Min(object expression)
        {
            return new Function("MIN()", expression);
        }

        public static IFunction Sum(object expression)
        {
            return new Function("SUM()", expression);
        }

        #endregion
    }
}