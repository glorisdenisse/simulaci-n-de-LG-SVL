// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: lattice_structure.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.planning
{

    [global::ProtoBuf.ProtoContract()]
    public partial class StopPoint : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public StopPoint()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public double s
        {
            get { return __pbn__s.GetValueOrDefault(); }
            set { __pbn__s = value; }
        }
        public bool ShouldSerializes()
        {
            return __pbn__s != null;
        }
        public void Resets()
        {
            __pbn__s = null;
        }
        private double? __pbn__s;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(Type.HARD)]
        public Type type
        {
            get { return __pbn__type ?? Type.HARD; }
            set { __pbn__type = value; }
        }
        public bool ShouldSerializetype()
        {
            return __pbn__type != null;
        }
        public void Resettype()
        {
            __pbn__type = null;
        }
        private Type? __pbn__type;

        [global::ProtoBuf.ProtoContract()]
        public enum Type
        {
            HARD = 0,
            SOFT = 1,
        }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class PlanningTarget : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public PlanningTarget()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public StopPoint stop_point { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public double cruise_speed
        {
            get { return __pbn__cruise_speed.GetValueOrDefault(); }
            set { __pbn__cruise_speed = value; }
        }
        public bool ShouldSerializecruise_speed()
        {
            return __pbn__cruise_speed != null;
        }
        public void Resetcruise_speed()
        {
            __pbn__cruise_speed = null;
        }
        private double? __pbn__cruise_speed;

    }

}

#pragma warning restore 0612, 1591, 3021
