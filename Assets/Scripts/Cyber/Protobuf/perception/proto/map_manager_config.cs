// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: map_manager_config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.lidar
{

    [global::ProtoBuf.ProtoContract()]
    public partial class MapManagerConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public MapManagerConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool update_pose
        {
            get { return __pbn__update_pose ?? false; }
            set { __pbn__update_pose = value; }
        }
        public bool ShouldSerializeupdate_pose()
        {
            return __pbn__update_pose != null;
        }
        public void Resetupdate_pose()
        {
            __pbn__update_pose = null;
        }
        private bool? __pbn__update_pose;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(80)]
        public double roi_search_distance
        {
            get { return __pbn__roi_search_distance ?? 80; }
            set { __pbn__roi_search_distance = value; }
        }
        public bool ShouldSerializeroi_search_distance()
        {
            return __pbn__roi_search_distance != null;
        }
        public void Resetroi_search_distance()
        {
            __pbn__roi_search_distance = null;
        }
        private double? __pbn__roi_search_distance;

        [global::ProtoBuf.ProtoMember(3)]
        public double lane_range
        {
            get { return __pbn__lane_range.GetValueOrDefault(); }
            set { __pbn__lane_range = value; }
        }
        public bool ShouldSerializelane_range()
        {
            return __pbn__lane_range != null;
        }
        public void Resetlane_range()
        {
            __pbn__lane_range = null;
        }
        private double? __pbn__lane_range;

        [global::ProtoBuf.ProtoMember(4)]
        public double max_depth
        {
            get { return __pbn__max_depth.GetValueOrDefault(); }
            set { __pbn__max_depth = value; }
        }
        public bool ShouldSerializemax_depth()
        {
            return __pbn__max_depth != null;
        }
        public void Resetmax_depth()
        {
            __pbn__max_depth = null;
        }
        private double? __pbn__max_depth;

    }

}

#pragma warning restore 0612, 1591, 3021
