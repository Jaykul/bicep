// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.
using Microsoft.VisualStudio.TestTools.UnitTesting;

// reduce parallelism for language server integration tests
[assembly: Parallelize(Scope = ExecutionScope.ClassLevel, Workers = 0)]
