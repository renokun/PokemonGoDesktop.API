// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: Data/PlayerBadge.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Data {

  /// <summary>Holder for reflection information generated from Data/PlayerBadge.proto</summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public static partial class PlayerBadgeReflection {

    #region Descriptor
    /// <summary>File descriptor for Data/PlayerBadge.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PlayerBadgeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChZEYXRhL1BsYXllckJhZGdlLnByb3RvEgREYXRhGhVFbnVtcy9CYWRnZVR5",
            "cGUucHJvdG8igAEKC1BsYXllckJhZGdlEiQKCmJhZGdlX3R5cGUYASABKA4y",
            "EC5FbnVtcy5CYWRnZVR5cGUSDAoEcmFuaxgCIAEoBRITCgtzdGFydF92YWx1",
            "ZRgDIAEoBRIRCgllbmRfdmFsdWUYBCABKAUSFQoNY3VycmVudF92YWx1ZRgF",
            "IAEoAWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Enums.BadgeTypeReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Data.PlayerBadge), global::Data.PlayerBadge.Parser, new[]{ "BadgeType", "Rank", "StartValue", "EndValue", "CurrentValue" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  public sealed partial class PlayerBadge : pb::IMessage<PlayerBadge> {
    private static readonly pb::MessageParser<PlayerBadge> _parser = new pb::MessageParser<PlayerBadge>(() => new PlayerBadge());
    public static pb::MessageParser<PlayerBadge> Parser { get { return _parser; } }

    public static pbr::MessageDescriptor Descriptor {
      get { return global::Data.PlayerBadgeReflection.Descriptor.MessageTypes[0]; }
    }

    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    public PlayerBadge() {
      OnConstruction();
    }

    partial void OnConstruction();

    public PlayerBadge(PlayerBadge other) : this() {
      badgeType_ = other.badgeType_;
      rank_ = other.rank_;
      startValue_ = other.startValue_;
      endValue_ = other.endValue_;
      currentValue_ = other.currentValue_;
    }

    public PlayerBadge Clone() {
      return new PlayerBadge(this);
    }

    /// <summary>Field number for the "badge_type" field.</summary>
    public const int BadgeTypeFieldNumber = 1;
    private global::Enums.BadgeType badgeType_ = 0;
    public global::Enums.BadgeType BadgeType {
      get { return badgeType_; }
      set {
        badgeType_ = value;
      }
    }

    /// <summary>Field number for the "rank" field.</summary>
    public const int RankFieldNumber = 2;
    private int rank_;
    public int Rank {
      get { return rank_; }
      set {
        rank_ = value;
      }
    }

    /// <summary>Field number for the "start_value" field.</summary>
    public const int StartValueFieldNumber = 3;
    private int startValue_;
    public int StartValue {
      get { return startValue_; }
      set {
        startValue_ = value;
      }
    }

    /// <summary>Field number for the "end_value" field.</summary>
    public const int EndValueFieldNumber = 4;
    private int endValue_;
    public int EndValue {
      get { return endValue_; }
      set {
        endValue_ = value;
      }
    }

    /// <summary>Field number for the "current_value" field.</summary>
    public const int CurrentValueFieldNumber = 5;
    private double currentValue_;
    public double CurrentValue {
      get { return currentValue_; }
      set {
        currentValue_ = value;
      }
    }

    public override bool Equals(object other) {
      return Equals(other as PlayerBadge);
    }

    public bool Equals(PlayerBadge other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (BadgeType != other.BadgeType) return false;
      if (Rank != other.Rank) return false;
      if (StartValue != other.StartValue) return false;
      if (EndValue != other.EndValue) return false;
      if (CurrentValue != other.CurrentValue) return false;
      return true;
    }

    public override int GetHashCode() {
      int hash = 1;
      if (BadgeType != 0) hash ^= BadgeType.GetHashCode();
      if (Rank != 0) hash ^= Rank.GetHashCode();
      if (StartValue != 0) hash ^= StartValue.GetHashCode();
      if (EndValue != 0) hash ^= EndValue.GetHashCode();
      if (CurrentValue != 0D) hash ^= CurrentValue.GetHashCode();
      return hash;
    }

    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    public void WriteTo(pb::CodedOutputStream output) {
      if (BadgeType != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) BadgeType);
      }
      if (Rank != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Rank);
      }
      if (StartValue != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(StartValue);
      }
      if (EndValue != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(EndValue);
      }
      if (CurrentValue != 0D) {
        output.WriteRawTag(41);
        output.WriteDouble(CurrentValue);
      }
    }

    public int CalculateSize() {
      int size = 0;
      if (BadgeType != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) BadgeType);
      }
      if (Rank != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Rank);
      }
      if (StartValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartValue);
      }
      if (EndValue != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EndValue);
      }
      if (CurrentValue != 0D) {
        size += 1 + 8;
      }
      return size;
    }

    public void MergeFrom(PlayerBadge other) {
      if (other == null) {
        return;
      }
      if (other.BadgeType != 0) {
        BadgeType = other.BadgeType;
      }
      if (other.Rank != 0) {
        Rank = other.Rank;
      }
      if (other.StartValue != 0) {
        StartValue = other.StartValue;
      }
      if (other.EndValue != 0) {
        EndValue = other.EndValue;
      }
      if (other.CurrentValue != 0D) {
        CurrentValue = other.CurrentValue;
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
            badgeType_ = (global::Enums.BadgeType) input.ReadEnum();
            break;
          }
          case 16: {
            Rank = input.ReadInt32();
            break;
          }
          case 24: {
            StartValue = input.ReadInt32();
            break;
          }
          case 32: {
            EndValue = input.ReadInt32();
            break;
          }
          case 41: {
            CurrentValue = input.ReadDouble();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code