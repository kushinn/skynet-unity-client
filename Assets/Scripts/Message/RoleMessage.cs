//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from: role_message.proto
namespace role_message
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgRoleListRequest")]
  public partial class CMsgRoleListRequest : global::ProtoBuf.IExtensible
  {
    public CMsgRoleListRequest() {}
    
    private string _accountid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"Role")]
  public partial class Role : global::ProtoBuf.IExtensible
  {
    public Role() {}
    
    private long _id;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"id", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public long id
    {
      get { return _id; }
      set { _id = value; }
    }
    private string _nickname;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"nickname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string nickname
    {
      get { return _nickname; }
      set { _nickname = value; }
    }
    private int _level;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"level", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int level
    {
      get { return _level; }
      set { _level = value; }
    }
    private int _roletype;
    [global::ProtoBuf.ProtoMember(4, IsRequired = true, Name=@"roletype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int roletype
    {
      get { return _roletype; }
      set { _roletype = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgRoleListResponse")]
  public partial class CMsgRoleListResponse : global::ProtoBuf.IExtensible
  {
    public CMsgRoleListResponse() {}
    
    private readonly global::System.Collections.Generic.List<Role> _roles = new global::System.Collections.Generic.List<Role>();
    [global::ProtoBuf.ProtoMember(1, Name=@"roles", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Role> roles
    {
      get { return _roles; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgRoleCreateRequest")]
  public partial class CMsgRoleCreateRequest : global::ProtoBuf.IExtensible
  {
    public CMsgRoleCreateRequest() {}
    
    private string _accountid;
    [global::ProtoBuf.ProtoMember(1, IsRequired = true, Name=@"accountid", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string accountid
    {
      get { return _accountid; }
      set { _accountid = value; }
    }
    private string _nickname;
    [global::ProtoBuf.ProtoMember(2, IsRequired = true, Name=@"nickname", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public string nickname
    {
      get { return _nickname; }
      set { _nickname = value; }
    }
    private int _roletype;
    [global::ProtoBuf.ProtoMember(3, IsRequired = true, Name=@"roletype", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public int roletype
    {
      get { return _roletype; }
      set { _roletype = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CMsgRoleCreateResponse")]
  public partial class CMsgRoleCreateResponse : global::ProtoBuf.IExtensible
  {
    public CMsgRoleCreateResponse() {}
    
    private readonly global::System.Collections.Generic.List<Role> _roles = new global::System.Collections.Generic.List<Role>();
    [global::ProtoBuf.ProtoMember(1, Name=@"roles", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<Role> roles
    {
      get { return _roles; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
}