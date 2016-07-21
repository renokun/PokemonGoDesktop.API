// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Requests/Messages/SetContactSettingsMessage.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Requests.Messages {

  /// <summary>Holder for reflection information generated from Networking/Requests/Messages/SetContactSettingsMessage.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class SetContactSettingsMessageReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Requests/Messages/SetContactSettingsMessage.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SetContactSettingsMessageReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjxOZXR3b3JraW5nL1JlcXVlc3RzL01lc3NhZ2VzL1NldENvbnRhY3RTZXR0",
            "aW5nc01lc3NhZ2UucHJvdG8SHE5ldHdvcmtpbmcuUmVxdWVzdHMuTWVzc2Fn",
            "ZXMaIURhdGEvUGxheWVyL0NvbnRhY3RTZXR0aW5ncy5wcm90byJTChlTZXRD",
            "b250YWN0U2V0dGluZ3NNZXNzYWdlEjYKEGNvbnRhY3Rfc2V0dGluZ3MYASAB",
            "KAsyHC5EYXRhLlBsYXllci5Db250YWN0U2V0dGluZ3NiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Data.Player.ContactSettingsReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Requests.Messages.SetContactSettingsMessage), global::Networking.Requests.Messages.SetContactSettingsMessage.Parser, new[]{ "ContactSettings" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class SetContactSettingsMessage : pb::IMessage<SetContactSettingsMessage> {
    private static readonly pb::MessageParser<SetContactSettingsMessage> _parser = new pb::MessageParser<SetContactSettingsMessage>(() => new SetContactSettingsMessage());
    public static pb::MessageParser<SetContactSettingsMessage> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Requests.Messages.SetContactSettingsMessageReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public SetContactSettingsMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    public SetContactSettingsMessage(SetContactSettingsMessage other) : this() {
      ContactSettings = other.contactSettings_ != null ? other.ContactSettings.Clone() : null;
    }

    public SetContactSettingsMessage Clone() {
      return new SetContactSettingsMessage(this);
    }

    /// <summary>Field number for the "contact_settings" field.</summary>
    public const int ContactSettingsFieldNumber = 1;
    private global::Data.Player.ContactSettings contactSettings_;
    public global::Data.Player.ContactSettings ContactSettings {
      get { return contactSettings_; }
      set {
        contactSettings_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as SetContactSettingsMessage);
    }

    public bool Equals(SetContactSettingsMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!object.Equals(ContactSettings, other.ContactSettings)) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (contactSettings_ != null) hash ^= ContactSettings.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (contactSettings_ != null) {
        output.WriteRawTag(10);
        output.WriteMessage(ContactSettings);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (contactSettings_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ContactSettings);
      }
      return size;
    }

    public void MergeFrom(SetContactSettingsMessage other) {
      if (other == null) {
        return;
      }
      if (other.contactSettings_ != null) {
        if (contactSettings_ == null) {
          contactSettings_ = new global::Data.Player.ContactSettings();
        }
        ContactSettings.MergeFrom(other.ContactSettings);
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 10: {
            if (contactSettings_ == null) {
              contactSettings_ = new global::Data.Player.ContactSettings();
            }
            input.ReadMessage(contactSettings_);
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code