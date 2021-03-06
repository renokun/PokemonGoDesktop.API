// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Settings/Master/Item/ReviveAttributes.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace PokemonGoDesktop.API.Proto {

  /// <summary>Holder for reflection information generated from Settings/Master/Item/ReviveAttributes.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class ReviveAttributesReflection {

    #region Descriptor
    /// <summary>File descriptor for Settings/Master/Item/ReviveAttributes.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ReviveAttributesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CitTZXR0aW5ncy9NYXN0ZXIvSXRlbS9SZXZpdmVBdHRyaWJ1dGVzLnByb3Rv",
            "EhRTZXR0aW5ncy5NYXN0ZXIuSXRlbSInChBSZXZpdmVBdHRyaWJ1dGVzEhMK",
            "C3N0YV9wZXJjZW50GAEgASgCQh2qAhpQb2tlbW9uR29EZXNrdG9wLkFQSS5Q",
            "cm90b2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::PokemonGoDesktop.API.Proto.ReviveAttributes), global::PokemonGoDesktop.API.Proto.ReviveAttributes.Parser, new[]{ "StaPercent" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class ReviveAttributes : pb::IMessage<ReviveAttributes> {
    private static readonly pb::MessageParser<ReviveAttributes> _parser = new pb::MessageParser<ReviveAttributes>(() => new ReviveAttributes());
    public static pb::MessageParser<ReviveAttributes> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::PokemonGoDesktop.API.Proto.ReviveAttributesReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public ReviveAttributes() {
      OnConstruction();
    }

    partial void OnConstruction();

    public ReviveAttributes(ReviveAttributes other) : this() {
      staPercent_ = other.staPercent_;
    }

    public ReviveAttributes Clone() {
      return new ReviveAttributes(this);
    }

    /// <summary>Field number for the "sta_percent" field.</summary>
    public const int StaPercentFieldNumber = 1;
    private float staPercent_;
    public float StaPercent {
      get { return staPercent_; }
      set {
        staPercent_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as ReviveAttributes);
    }

    public bool Equals(ReviveAttributes other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StaPercent != other.StaPercent) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (StaPercent != 0F) hash ^= StaPercent.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (StaPercent != 0F) {
        output.WriteRawTag(13);
        output.WriteFloat(StaPercent);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (StaPercent != 0F) {
        size += 1 + 4;
      }
      return size;
    }

    public void MergeFrom(ReviveAttributes other) {
      if (other == null) {
        return;
      }
      if (other.StaPercent != 0F) {
        StaPercent = other.StaPercent;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 13: {
            StaPercent = input.ReadFloat();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
