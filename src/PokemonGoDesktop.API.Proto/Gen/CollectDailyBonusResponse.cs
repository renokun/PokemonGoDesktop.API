// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Networking/Responses/CollectDailyBonusResponse.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Networking.Responses {

  /// <summary>Holder for reflection information generated from Networking/Responses/CollectDailyBonusResponse.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class CollectDailyBonusResponseReflection {

    #region Descriptor
    /// <summary>File descriptor for Networking/Responses/CollectDailyBonusResponse.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CollectDailyBonusResponseReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjROZXR3b3JraW5nL1Jlc3BvbnNlcy9Db2xsZWN0RGFpbHlCb251c1Jlc3Bv",
            "bnNlLnByb3RvEhROZXR3b3JraW5nLlJlc3BvbnNlcyKgAQoZQ29sbGVjdERh",
            "aWx5Qm9udXNSZXNwb25zZRJGCgZyZXN1bHQYASABKA4yNi5OZXR3b3JraW5n",
            "LlJlc3BvbnNlcy5Db2xsZWN0RGFpbHlCb251c1Jlc3BvbnNlLlJlc3VsdCI7",
            "CgZSZXN1bHQSCQoFVU5TRVQQABILCgdTVUNDRVNTEAESCwoHRkFJTFVSRRAC",
            "EgwKCFRPT19TT09OEANiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Networking.Responses.CollectDailyBonusResponse), global::Networking.Responses.CollectDailyBonusResponse.Parser, new[]{ "Result" }, null, new[]{ typeof(global::Networking.Responses.CollectDailyBonusResponse.Types.Result) }, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class CollectDailyBonusResponse : pb::IMessage<CollectDailyBonusResponse> {
    private static readonly pb::MessageParser<CollectDailyBonusResponse> _parser = new pb::MessageParser<CollectDailyBonusResponse>(() => new CollectDailyBonusResponse());
    public static pb::MessageParser<CollectDailyBonusResponse> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Networking.Responses.CollectDailyBonusResponseReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public CollectDailyBonusResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    public CollectDailyBonusResponse(CollectDailyBonusResponse other) : this() {
      result_ = other.result_;
    }

    public CollectDailyBonusResponse Clone() {
      return new CollectDailyBonusResponse(this);
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 1;
    private global::Networking.Responses.CollectDailyBonusResponse.Types.Result result_ = 0;
    public global::Networking.Responses.CollectDailyBonusResponse.Types.Result Result {
      get { return result_; }
      set {
        result_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as CollectDailyBonusResponse);
    }

    public bool Equals(CollectDailyBonusResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Result != other.Result) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (Result != 0) hash ^= Result.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (Result != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Result);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (Result != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Result);
      }
      return size;
    }

    public void MergeFrom(CollectDailyBonusResponse other) {
      if (other == null) {
        return;
      }
      if (other.Result != 0) {
        Result = other.Result;
      }
    }

    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            result_ = (global::Networking.Responses.CollectDailyBonusResponse.Types.Result) input.ReadEnum();
            break;
          }
        }
      }
    }

    #region Nested types
    /// <summary>Container for nested types declared in the CollectDailyBonusResponse message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    public static partial class Types {
      public enum Result {
        [pbr::OriginalName("UNSET")] Unset = 0,
        [pbr::OriginalName("SUCCESS")] Success = 1,
        [pbr::OriginalName("FAILURE")] Failure = 2,
        [pbr::OriginalName("TOO_SOON")] TooSoon = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code