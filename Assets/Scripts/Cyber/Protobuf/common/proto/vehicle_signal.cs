// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: vehicle_signal.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.common
{

    [global::ProtoBuf.ProtoContract()]
    public partial class VehicleSignal : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public VehicleSignal()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(TurnSignal.TURN_NONE)]
        public TurnSignal turn_signal
        {
            get { return __pbn__turn_signal ?? TurnSignal.TURN_NONE; }
            set { __pbn__turn_signal = value; }
        }
        public bool ShouldSerializeturn_signal()
        {
            return __pbn__turn_signal != null;
        }
        public void Resetturn_signal()
        {
            __pbn__turn_signal = null;
        }
        private TurnSignal? __pbn__turn_signal;

        [global::ProtoBuf.ProtoMember(2)]
        public bool high_beam
        {
            get { return __pbn__high_beam.GetValueOrDefault(); }
            set { __pbn__high_beam = value; }
        }
        public bool ShouldSerializehigh_beam()
        {
            return __pbn__high_beam != null;
        }
        public void Resethigh_beam()
        {
            __pbn__high_beam = null;
        }
        private bool? __pbn__high_beam;

        [global::ProtoBuf.ProtoMember(3)]
        public bool low_beam
        {
            get { return __pbn__low_beam.GetValueOrDefault(); }
            set { __pbn__low_beam = value; }
        }
        public bool ShouldSerializelow_beam()
        {
            return __pbn__low_beam != null;
        }
        public void Resetlow_beam()
        {
            __pbn__low_beam = null;
        }
        private bool? __pbn__low_beam;

        [global::ProtoBuf.ProtoMember(4)]
        public bool horn
        {
            get { return __pbn__horn.GetValueOrDefault(); }
            set { __pbn__horn = value; }
        }
        public bool ShouldSerializehorn()
        {
            return __pbn__horn != null;
        }
        public void Resethorn()
        {
            __pbn__horn = null;
        }
        private bool? __pbn__horn;

        [global::ProtoBuf.ProtoMember(5)]
        public bool emergency_light
        {
            get { return __pbn__emergency_light.GetValueOrDefault(); }
            set { __pbn__emergency_light = value; }
        }
        public bool ShouldSerializeemergency_light()
        {
            return __pbn__emergency_light != null;
        }
        public void Resetemergency_light()
        {
            __pbn__emergency_light = null;
        }
        private bool? __pbn__emergency_light;

        [global::ProtoBuf.ProtoContract()]
        public enum TurnSignal
        {
            TURN_NONE = 0,
            TURN_LEFT = 1,
            TURN_RIGHT = 2,
        }

    }

}

#pragma warning restore 0612, 1591, 3021
