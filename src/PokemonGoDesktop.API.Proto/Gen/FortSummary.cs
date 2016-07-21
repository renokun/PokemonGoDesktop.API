// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Map/Fort/FortSummary.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Map.Fort {

  /// <summary>Holder for reflection information generated from Map/Fort/FortSummary.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class FortSummaryReflection {

    #region Descriptor
    /// <summary>File descriptor for Map/Fort/FortSummary.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static FortSummaryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChpNYXAvRm9ydC9Gb3J0U3VtbWFyeS5wcm90bxIITWFwLkZvcnQibwoLRm9y",
            "dFN1bW1hcnkSFwoPZm9ydF9zdW1tYXJ5X2lkGAEgASgFEiIKGmxhc3RfbW9k",
            "aWZpZWRfdGltZXN0YW1wX21zGAIgASgFEhAKCGxhdGl0dWRlGAMgASgFEhEK",
            "CWxvbmdpdHVkZRgEIAEoBWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Map.Fort.FortSummary), global::Map.Fort.FortSummary.Parser, new[]{ "FortSummaryId", "LastModifiedTimestampMs", "Latitude", "Longitude" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class FortSummary : pb::IMessage<FortSummary> {
    private static readonly pb::MessageParser<FortSummary> _parser = new pb::MessageParser<FortSummary>(() => new FortSummary());
    public static pb::MessageParser<FortSummary> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Map.Fort.FortSummaryReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public FortSummary() {
      OnConstruction();
    }

    partial void OnConstruction();

    public FortSummary(FortSummary other) : this() {
      fortSummaryId_ = other.fortSummaryId_;
      lastModifiedTimestampMs_ = other.lastModifiedTimestampMs_;
      latitude_ = other.latitude_;
      longitude_ = other.longitude_;
    }

    public FortSummary Clone() {
      return new FortSummary(this);
    }

    /// <summary>Field number for the "fort_summary_id" field.</summary>
    public const int FortSummaryIdFieldNumber = 1;
    private int fortSummaryId_;
    public int FortSummaryId {
      get { return fortSummaryId_; }
      set {
        fortSummaryId_ = value;
      }
    }

    /// <summary>Field number for the "last_modified_timestamp_ms" field.</summary>
    public const int LastModifiedTimestampMsFieldNumber = 2;
    private int lastModifiedTimestampMs_;
    public int LastModifiedTimestampMs {
      get { return lastModifiedTimestampMs_; }
      set {
        lastModifiedTimestampMs_ = value;
      }
    }

    /// <summary>Field number for the "latitude" field.</summary>
    public const int LatitudeFieldNumber = 3;
    private int latitude_;
    public int Latitude {
      get { return latitude_; }
      set {
        latitude_ = value;
      }
    }

    /// <summary>Field number for the "longitude" field.</summary>
    public const int LongitudeFieldNumber = 4;
    private int longitude_;
    public int Longitude {
      get { return longitude_; }
      set {
        longitude_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as FortSummary);
    }

    public bool Equals(FortSummary other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (FortSummaryId != other.FortSummaryId) return false;
      if (LastModifiedTimestampMs != other.LastModifiedTimestampMs) return false;
      if (Latitude != other.Latitude) return false;
      if (Longitude != other.Longitude) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (FortSummaryId != 0) hash ^= FortSummaryId.GetHashCode();
      if (LastModifiedTimestampMs != 0) hash ^= LastModifiedTimestampMs.GetHashCode();
      if (Latitude != 0) hash ^= Latitude.GetHashCode();
      if (Longitude != 0) hash ^= Longitude.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (FortSummaryId != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(FortSummaryId);
      }
      if (LastModifiedTimestampMs != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(LastModifiedTimestampMs);
      }
      if (Latitude != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Latitude);
      }
      if (Longitude != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Longitude);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (FortSummaryId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(FortSummaryId);
      }
      if (LastModifiedTimestampMs != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(LastModifiedTimestampMs);
      }
      if (Latitude != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Latitude);
      }
      if (Longitude != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Longitude);
      }
      return size;
    }

    public void MergeFrom(FortSummary other) {
      if (other == null) {
        return;
      }
      if (other.FortSummaryId != 0) {
        FortSummaryId = other.FortSummaryId;
      }
      if (other.LastModifiedTimestampMs != 0) {
        LastModifiedTimestampMs = other.LastModifiedTimestampMs;
      }
      if (other.Latitude != 0) {
        Latitude = other.Latitude;
      }
      if (other.Longitude != 0) {
        Longitude = other.Longitude;
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
            FortSummaryId = input.ReadInt32();
            break;
          }
          case 16: {
            LastModifiedTimestampMs = input.ReadInt32();
            break;
          }
          case 24: {
            Latitude = input.ReadInt32();
            break;
          }
          case 32: {
            Longitude = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code