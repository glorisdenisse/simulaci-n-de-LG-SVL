// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: spatio_temporal_ground_detector_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.lidar
{

    [global::ProtoBuf.ProtoContract()]
    public partial class SpatioTemporalGroundDetectorConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public SpatioTemporalGroundDetectorConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(16)]
        public uint grid_size
        {
            get { return __pbn__grid_size ?? 16; }
            set { __pbn__grid_size = value; }
        }
        public bool ShouldSerializegrid_size()
        {
            return __pbn__grid_size != null;
        }
        public void Resetgrid_size()
        {
            __pbn__grid_size = null;
        }
        private uint? __pbn__grid_size;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0.25f)]
        public float ground_thres
        {
            get { return __pbn__ground_thres ?? 0.25f; }
            set { __pbn__ground_thres = value; }
        }
        public bool ShouldSerializeground_thres()
        {
            return __pbn__ground_thres != null;
        }
        public void Resetground_thres()
        {
            __pbn__ground_thres = null;
        }
        private float? __pbn__ground_thres;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(120f)]
        public float roi_rad_x
        {
            get { return __pbn__roi_rad_x ?? 120f; }
            set { __pbn__roi_rad_x = value; }
        }
        public bool ShouldSerializeroi_rad_x()
        {
            return __pbn__roi_rad_x != null;
        }
        public void Resetroi_rad_x()
        {
            __pbn__roi_rad_x = null;
        }
        private float? __pbn__roi_rad_x;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(120f)]
        public float roi_rad_y
        {
            get { return __pbn__roi_rad_y ?? 120f; }
            set { __pbn__roi_rad_y = value; }
        }
        public bool ShouldSerializeroi_rad_y()
        {
            return __pbn__roi_rad_y != null;
        }
        public void Resetroi_rad_y()
        {
            __pbn__roi_rad_y = null;
        }
        private float? __pbn__roi_rad_y;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(100f)]
        public float roi_rad_z
        {
            get { return __pbn__roi_rad_z ?? 100f; }
            set { __pbn__roi_rad_z = value; }
        }
        public bool ShouldSerializeroi_rad_z()
        {
            return __pbn__roi_rad_z != null;
        }
        public void Resetroi_rad_z()
        {
            __pbn__roi_rad_z = null;
        }
        private float? __pbn__roi_rad_z;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(5)]
        public uint nr_smooth_iter
        {
            get { return __pbn__nr_smooth_iter ?? 5; }
            set { __pbn__nr_smooth_iter = value; }
        }
        public bool ShouldSerializenr_smooth_iter()
        {
            return __pbn__nr_smooth_iter != null;
        }
        public void Resetnr_smooth_iter()
        {
            __pbn__nr_smooth_iter = null;
        }
        private uint? __pbn__nr_smooth_iter;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool use_roi
        {
            get { return __pbn__use_roi ?? true; }
            set { __pbn__use_roi = value; }
        }
        public bool ShouldSerializeuse_roi()
        {
            return __pbn__use_roi != null;
        }
        public void Resetuse_roi()
        {
            __pbn__use_roi = null;
        }
        private bool? __pbn__use_roi;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(true)]
        public bool use_ground_service
        {
            get { return __pbn__use_ground_service ?? true; }
            set { __pbn__use_ground_service = value; }
        }
        public bool ShouldSerializeuse_ground_service()
        {
            return __pbn__use_ground_service != null;
        }
        public void Resetuse_ground_service()
        {
            __pbn__use_ground_service = null;
        }
        private bool? __pbn__use_ground_service;

    }

}

#pragma warning restore 0612, 1591, 3021
