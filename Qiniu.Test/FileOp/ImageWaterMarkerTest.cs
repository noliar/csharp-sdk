﻿using System;
using Qiniu.FileOp;
using Qiniu.RS;
#if NET20 || NET40
using NUnit.Framework;
#else
using Xunit;
#endif

namespace Qiniu.Test.FileOp
{


    /// <summary>
    ///这是 ImageWaterMarkerTest 的测试类，旨在
    ///包含所有 ImageWaterMarkerTest 单元测试
    ///</summary>
#if NET20 || NET40
    //[TestFixture]
#endif
    public class ImageWaterMarkerTest:QiniuTestBase
    {
        /// <summary>
        ///MakeRequest 的测试
        ///</summary>
#if NET20 || NET40
        //[Test]
#else
        //[Fact]
#endif
        public void MakeRequestTest()
        {
            string imageUrl = "http://www.b1.qiniudn.com/images/logo-2.png"; // TODO: 初始化为适当的值
            int dissolve = 50; // TODO: 初始化为适当的值
            ImageWaterMarker target = new ImageWaterMarker(imageUrl,dissolve,MarkerGravity.Center); // TODO: 初始化为适当的值
            string actual;
            actual = target.MakeRequest(FileOpUrl);
            // 如果是私有空间，添加下面一句
            actual = GetPolicy.MakeRequest(actual);
            //System.Diagnostics.Process.Start(actual);
            PrintLn(actual);
#if NET20 || NET40
            Assert.IsTrue(!string.IsNullOrEmpty(actual), "ImageWaterMarkerTest MakeRequestTest Failure");
#else
            Assert.True(!string.IsNullOrEmpty(actual), "ImageWaterMarkerTest MakeRequestTest Failure");
#endif

        }
    }
}
