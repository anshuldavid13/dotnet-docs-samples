﻿// Copyright 2021 Google Inc.
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

// [START storage_file_download_from_memory]

using System;
using System.Collections.Generic;
using System.Text;
using Google.Apis.Storage.v1.Data;
using Google.Cloud.Storage.V1;
using System.IO;

public class DownloadObjectIntoMemorySample
{
    public Stream DownloadObjectIntoMemory(
        string bucketName = "your-unique-bucket-name",
        string objectName = "my-file-name")
    {
        var storage = StorageClient.Create();
        Stream stream = new MemoryStream();
        storage.DownloadObject(bucketName, objectName, stream);

        Console.WriteLine($"The contents of {objectName} from bucket {bucketName} are {stream}");
        return stream;
    }
}

// [END storage_file_download_from_memory]
