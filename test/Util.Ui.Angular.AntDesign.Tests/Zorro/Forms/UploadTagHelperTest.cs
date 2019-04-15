﻿using System.Collections.Generic;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Util.Helpers;
using Util.Ui.Angular.AntDesign.Tests.XUnitHelpers;
using Util.Ui.Configs;
using Util.Ui.Enums;
using Util.Ui.Zorro.Enums;
using Util.Ui.Zorro.Forms;
using Xunit;
using Xunit.Abstractions;
using String = Util.Helpers.String;

namespace Util.Ui.Angular.AntDesign.Tests.Zorro.Forms {
    /// <summary>
    /// 文件上传控件测试
    /// </summary>
    public class UploadTagHelperTest {
        /// <summary>
        /// 输出工具
        /// </summary>
        private readonly ITestOutputHelper _output;
        /// <summary>
        /// 文件上传
        /// </summary>
        private readonly UploadTagHelper _component;

        /// <summary>
        /// 测试初始化
        /// </summary>
        public UploadTagHelperTest( ITestOutputHelper output ) {
            _output = output;
            _component = new UploadTagHelper();
            Config.IsValidate = false;
            Id.SetId( "id" );
        }

        /// <summary>
        /// 获取结果
        /// </summary>
        private string GetResult( TagHelperAttributeList contextAttributes = null, TagHelperAttributeList outputAttributes = null, TagHelperContent content = null ) {
            return Helper.GetResult( _output, _component, contextAttributes, outputAttributes, content );
        }

        /// <summary>
        /// 测试默认输出
        /// </summary>
        [Fact]
        public void TestDefault() {
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult() );
        }

        /// <summary>
        /// 测试添加标识
        /// </summary>
        [Fact]
        public void TestId() {
            var attributes = new TagHelperAttributeList { { UiConst.Id, "a" } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #a_wrapper=\"\">" );
            result.Append( "<nz-upload #a=\"\" (nzChange)=\"a_wrapper.handleChange($event)\" [nzFilter]=\"a_wrapper.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试上传地址
        /// </summary>
        [Fact]
        public void TestUrl() {
            var attributes = new TagHelperAttributeList { { UiConst.Url, "a" } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" nzAction=\"a\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试上传地址
        /// </summary>
        [Fact]
        public void TestBindUrl() {
            var attributes = new TagHelperAttributeList { { AngularConst.BindUrl, "a" } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" [nzAction]=\"a\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试多选
        /// </summary>
        [Fact]
        public void TestMultiple() {
            var attributes = new TagHelperAttributeList { { UiConst.Multiple, true } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" [nzFilter]=\"m_id.filters\" [nzMultiple]=\"true\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试按钮文本
        /// </summary>
        [Fact]
        public void TestButtonText() {
            var attributes = new TagHelperAttributeList { { UiConst.ButtonText, "a" } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"a\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试按钮图标
        /// </summary>
        [Fact]
        public void TestButtonIcon() {
            var attributes = new TagHelperAttributeList { { UiConst.ButtonIcon, AntDesignIcon.Check } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"check\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试接受上传的文件类型
        /// </summary>
        [Fact]
        public void TestAccept() {
            var attributes = new TagHelperAttributeList { { UiConst.Accept, "a" } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" nzAccept=\"a\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试文件类型限制
        /// </summary>
        [Fact]
        public void TestFileType() {
            var attributes = new TagHelperAttributeList { { UiConst.FileType, "a" } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" nzFileType=\"a\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试允许上传图片文件
        /// </summary>
        [Fact]
        public void TestAcceptImage() {
            var attributes = new TagHelperAttributeList { { UiConst.AcceptImage, true } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload " );
            result.Append( "(nzChange)=\"m_id.handleChange($event)\" nzAccept=\".jpg,.jpeg,.png,.gif,.bmp\" " );
            result.Append( "nzFileType=\"image/jpeg,image/png,image/gif,image/bmp\" " );
            result.Append( "[nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试图片文件类型限制 - Jpg
        /// </summary>
        [Fact]
        public void TestImageTypes_Jpg() {
            var attributes = new TagHelperAttributeList { { UiConst.ImageTypes, new List<ImageType> { ImageType.Jpg } } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" nzAccept=\".jpg,.jpeg\" nzFileType=\"image/jpeg\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试图片文件类型限制 - Jpg + Png
        /// </summary>
        [Fact]
        public void TestImageTypes_Jpg_Png() {
            var attributes = new TagHelperAttributeList { { UiConst.ImageTypes, new List<ImageType> { ImageType.Jpg, ImageType.Png } } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" nzAccept=\".jpg,.jpeg,.png\" nzFileType=\"image/jpeg,image/png\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试文件大小限制
        /// </summary>
        [Fact]
        public void TestSize() {
            var attributes = new TagHelperAttributeList { { UiConst.Size, 1.1 } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" nzSize=\"1.1\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试上传文件夹
        /// </summary>
        [Fact]
        public void TestDirectory() {
            var attributes = new TagHelperAttributeList { { UiConst.Directory, true } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" [nzDirectory]=\"true\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试上传参数
        /// </summary>
        [Fact]
        public void TestData() {
            var attributes = new TagHelperAttributeList { { UiConst.Data, "a" } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" [nzData]=\"a\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试上传状态改变事件
        /// </summary>
        [Fact]
        public void TestOnChange() {
            var attributes = new TagHelperAttributeList { { UiConst.OnChange, "a" } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"a\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试上传前事件
        /// </summary>
        [Fact]
        public void TestOnBeforeUpload() {
            var attributes = new TagHelperAttributeList { { UiConst.OnBeforeUpload, "a" } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" [nzBeforeUpload]=\"a\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试过滤器
        /// </summary>
        [Fact]
        public void TestFilter() {
            var attributes = new TagHelperAttributeList { { UiConst.Filter, "a" } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" [nzFilter]=\"a\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }

        /// <summary>
        /// 测试单次最大上传数量限制
        /// </summary>
        [Fact]
        public void TestLimit() {
            var attributes = new TagHelperAttributeList { { UiConst.Limit, 2 } };
            var result = new String();
            result.Append( "<nz-upload-wrapper #m_id=\"\">" );
            result.Append( "<nz-upload (nzChange)=\"m_id.handleChange($event)\" nzLimit=\"2\" [nzFilter]=\"m_id.filters\">" );
            result.Append( "<x-button text=\"上传\">" );
            result.Append( "<ng-template>" );
            result.Append( "<i nz-icon=\"\" nzType=\"upload\"></i>" );
            result.Append( "</ng-template>" );
            result.Append( "</x-button>" );
            result.Append( "</nz-upload>" );
            result.Append( "</nz-upload-wrapper>" );
            Assert.Equal( result.ToString(), GetResult( attributes ) );
        }
    }
}