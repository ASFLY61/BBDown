﻿// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: my.proto
// </auto-generated>

#region Designer generated code
#pragma warning disable CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
[global::ProtoBuf.ProtoContract()]
public partial class Device : global::ProtoBuf.IExtensible
{
    private global::ProtoBuf.IExtension __pbn__extensionData;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        => global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);

    [global::ProtoBuf.ProtoMember(1)]
    public int appId
    {
        get => __pbn__appId.GetValueOrDefault();
        set => __pbn__appId = value;
    }
    public bool ShouldSerializeappId() => __pbn__appId != null;
    public void ResetappId() => __pbn__appId = null;
    private int? __pbn__appId;

    [global::ProtoBuf.ProtoMember(2, Name = @"build")]
    public int Build
    {
        get => __pbn__Build.GetValueOrDefault();
        set => __pbn__Build = value;
    }
    public bool ShouldSerializeBuild() => __pbn__Build != null;
    public void ResetBuild() => __pbn__Build = null;
    private int? __pbn__Build;

    [global::ProtoBuf.ProtoMember(3, Name = @"buvid")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Buvid
    {
        get => __pbn__Buvid ?? "";
        set => __pbn__Buvid = value;
    }
    public bool ShouldSerializeBuvid() => __pbn__Buvid != null;
    public void ResetBuvid() => __pbn__Buvid = null;
    private string __pbn__Buvid;

    [global::ProtoBuf.ProtoMember(4)]
    [global::System.ComponentModel.DefaultValue("")]
    public string mobiApp
    {
        get => __pbn__mobiApp ?? "";
        set => __pbn__mobiApp = value;
    }
    public bool ShouldSerializemobiApp() => __pbn__mobiApp != null;
    public void ResetmobiApp() => __pbn__mobiApp = null;
    private string __pbn__mobiApp;

    [global::ProtoBuf.ProtoMember(5, Name = @"platform")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Platform
    {
        get => __pbn__Platform ?? "";
        set => __pbn__Platform = value;
    }
    public bool ShouldSerializePlatform() => __pbn__Platform != null;
    public void ResetPlatform() => __pbn__Platform = null;
    private string __pbn__Platform;

    [global::ProtoBuf.ProtoMember(6)]
    [global::System.ComponentModel.DefaultValue("")]
    public string device
    {
        get => __pbn__device ?? "";
        set => __pbn__device = value;
    }
    public bool ShouldSerializedevice() => __pbn__device != null;
    public void Resetdevice() => __pbn__device = null;
    private string __pbn__device;

    [global::ProtoBuf.ProtoMember(7, Name = @"channel")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Channel
    {
        get => __pbn__Channel ?? "";
        set => __pbn__Channel = value;
    }
    public bool ShouldSerializeChannel() => __pbn__Channel != null;
    public void ResetChannel() => __pbn__Channel = null;
    private string __pbn__Channel;

    [global::ProtoBuf.ProtoMember(8, Name = @"brand")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Brand
    {
        get => __pbn__Brand ?? "";
        set => __pbn__Brand = value;
    }
    public bool ShouldSerializeBrand() => __pbn__Brand != null;
    public void ResetBrand() => __pbn__Brand = null;
    private string __pbn__Brand;

    [global::ProtoBuf.ProtoMember(9, Name = @"model")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Model
    {
        get => __pbn__Model ?? "";
        set => __pbn__Model = value;
    }
    public bool ShouldSerializeModel() => __pbn__Model != null;
    public void ResetModel() => __pbn__Model = null;
    private string __pbn__Model;

    [global::ProtoBuf.ProtoMember(10, Name = @"osver")]
    [global::System.ComponentModel.DefaultValue("")]
    public string Osver
    {
        get => __pbn__Osver ?? "";
        set => __pbn__Osver = value;
    }
    public bool ShouldSerializeOsver() => __pbn__Osver != null;
    public void ResetOsver() => __pbn__Osver = null;
    private string __pbn__Osver;

}

#pragma warning restore CS0612, CS0618, CS1591, CS3021, IDE0079, IDE1006, RCS1036, RCS1057, RCS1085, RCS1192
#endregion