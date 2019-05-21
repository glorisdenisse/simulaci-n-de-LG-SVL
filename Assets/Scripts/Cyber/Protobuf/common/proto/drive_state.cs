// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: drive_state.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.common
{

    [global::ProtoBuf.ProtoContract()]
    public partial class EngageAdvice : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public EngageAdvice()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(Advice.DISALLOW_ENGAGE)]
        public Advice advice
        {
            get { return __pbn__advice ?? Advice.DISALLOW_ENGAGE; }
            set { __pbn__advice = value; }
        }
        public bool ShouldSerializeadvice()
        {
            return __pbn__advice != null;
        }
        public void Resetadvice()
        {
            __pbn__advice = null;
        }
        private Advice? __pbn__advice;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string reason
        {
            get { return __pbn__reason ?? ""; }
            set { __pbn__reason = value; }
        }
        public bool ShouldSerializereason()
        {
            return __pbn__reason != null;
        }
        public void Resetreason()
        {
            __pbn__reason = null;
        }
        private string __pbn__reason;

        [global::ProtoBuf.ProtoContract()]
        public enum Advice
        {
            UNKNOWN = 0,
            DISALLOW_ENGAGE = 1,
            READY_TO_ENGAGE = 2,
            KEEP_ENGAGED = 3,
            PREPARE_DISENGAGE = 4,
        }

    }

}

#pragma warning restore 0612, 1591, 3021
