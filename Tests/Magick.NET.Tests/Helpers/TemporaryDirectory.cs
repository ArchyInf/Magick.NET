﻿//=================================================================================================
// Copyright 2013-2017 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
// express or implied. See the License for the specific language governing permissions and
// limitations under the License.
//=================================================================================================

using System;
using System.IO;

namespace Magick.NET.Tests
{
    [ExcludeFromCodeCoverage]
    public class TemporaryDirectory : IDisposable
    {
        private DirectoryInfo _TempDirectory;

        public TemporaryDirectory()
        {
            _TempDirectory = new DirectoryInfo(Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString()));
            _TempDirectory.Create();
        }

        public void Dispose()
        {
            if (_TempDirectory.Exists)
                _TempDirectory.Delete(true);
        }

        public DirectoryInfo DirectoryInfo
        {
            get
            {
                return _TempDirectory;
            }
        }
    }
}
