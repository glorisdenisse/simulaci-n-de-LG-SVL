// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: fused_classifier_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.lidar
{

    [global::ProtoBuf.ProtoContract()]
    public partial class FusedClassifierConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public FusedClassifierConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(20)]
        public double temporal_window
        {
            get { return __pbn__temporal_window ?? 20; }
            set { __pbn__temporal_window = value; }
        }
        public bool ShouldSerializetemporal_window()
        {
            return __pbn__temporal_window != null;
        }
        public void Resettemporal_window()
        {
            __pbn__temporal_window = null;
        }
        private double? __pbn__temporal_window;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool enable_temporal_fusion
        {
            get { return __pbn__enable_temporal_fusion ?? true; }
            set { __pbn__enable_temporal_fusion = value; }
        }
        public bool ShouldSerializeenable_temporal_fusion()
        {
            return __pbn__enable_temporal_fusion != null;
        }
        public void Resetenable_temporal_fusion()
        {
            __pbn__enable_temporal_fusion = null;
        }
        private bool? __pbn__enable_temporal_fusion;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(@"CCRFOneShotTypeFusion")]
        public string one_shot_fusion_method
        {
            get { return __pbn__one_shot_fusion_method ?? @"CCRFOneShotTypeFusion"; }
            set { __pbn__one_shot_fusion_method = value; }
        }
        public bool ShouldSerializeone_shot_fusion_method()
        {
            return __pbn__one_shot_fusion_method != null;
        }
        public void Resetone_shot_fusion_method()
        {
            __pbn__one_shot_fusion_method = null;
        }
        private string __pbn__one_shot_fusion_method;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(@"CCRFSequenceTypeFusion")]
        public string sequence_fusion_method
        {
            get { return __pbn__sequence_fusion_method ?? @"CCRFSequenceTypeFusion"; }
            set { __pbn__sequence_fusion_method = value; }
        }
        public bool ShouldSerializesequence_fusion_method()
        {
            return __pbn__sequence_fusion_method != null;
        }
        public void Resetsequence_fusion_method()
        {
            __pbn__sequence_fusion_method = null;
        }
        private string __pbn__sequence_fusion_method;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool use_tracked_objects
        {
            get { return __pbn__use_tracked_objects ?? true; }
            set { __pbn__use_tracked_objects = value; }
        }
        public bool ShouldSerializeuse_tracked_objects()
        {
            return __pbn__use_tracked_objects != null;
        }
        public void Resetuse_tracked_objects()
        {
            __pbn__use_tracked_objects = null;
        }
        private bool? __pbn__use_tracked_objects;

    }

}

#pragma warning restore 0612, 1591, 3021
