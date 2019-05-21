// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: config.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.drivers.velodyne
{

    [global::ProtoBuf.ProtoContract()]
    public partial class Config : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public Config()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string frame_id
        {
            get { return __pbn__frame_id ?? ""; }
            set { __pbn__frame_id = value; }
        }
        public bool ShouldSerializeframe_id()
        {
            return __pbn__frame_id != null;
        }
        public void Resetframe_id()
        {
            __pbn__frame_id = null;
        }
        private string __pbn__frame_id;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue("")]
        public string scan_channel
        {
            get { return __pbn__scan_channel ?? ""; }
            set { __pbn__scan_channel = value; }
        }
        public bool ShouldSerializescan_channel()
        {
            return __pbn__scan_channel != null;
        }
        public void Resetscan_channel()
        {
            __pbn__scan_channel = null;
        }
        private string __pbn__scan_channel;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(600)]
        public double rpm
        {
            get { return __pbn__rpm ?? 600; }
            set { __pbn__rpm = value; }
        }
        public bool ShouldSerializerpm()
        {
            return __pbn__rpm != null;
        }
        public void Resetrpm()
        {
            __pbn__rpm = null;
        }
        private double? __pbn__rpm;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(Model.UNKOWN)]
        public Model model
        {
            get { return __pbn__model ?? Model.UNKOWN; }
            set { __pbn__model = value; }
        }
        public bool ShouldSerializemodel()
        {
            return __pbn__model != null;
        }
        public void Resetmodel()
        {
            __pbn__model = null;
        }
        private Model? __pbn__model;

        [global::ProtoBuf.ProtoMember(21)]
        [global::System.ComponentModel.DefaultValue(Mode.STRONGEST)]
        public Mode mode
        {
            get { return __pbn__mode ?? Mode.STRONGEST; }
            set { __pbn__mode = value; }
        }
        public bool ShouldSerializemode()
        {
            return __pbn__mode != null;
        }
        public void Resetmode()
        {
            __pbn__mode = null;
        }
        private Mode? __pbn__mode;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue("")]
        public string pcap
        {
            get { return __pbn__pcap ?? ""; }
            set { __pbn__pcap = value; }
        }
        public bool ShouldSerializepcap()
        {
            return __pbn__pcap != null;
        }
        public void Resetpcap()
        {
            __pbn__pcap = null;
        }
        private string __pbn__pcap;

        [global::ProtoBuf.ProtoMember(6)]
        public int prefix_angle
        {
            get { return __pbn__prefix_angle.GetValueOrDefault(); }
            set { __pbn__prefix_angle = value; }
        }
        public bool ShouldSerializeprefix_angle()
        {
            return __pbn__prefix_angle != null;
        }
        public void Resetprefix_angle()
        {
            __pbn__prefix_angle = null;
        }
        private int? __pbn__prefix_angle;

        [global::ProtoBuf.ProtoMember(7)]
        public int firing_data_port
        {
            get { return __pbn__firing_data_port.GetValueOrDefault(); }
            set { __pbn__firing_data_port = value; }
        }
        public bool ShouldSerializefiring_data_port()
        {
            return __pbn__firing_data_port != null;
        }
        public void Resetfiring_data_port()
        {
            __pbn__firing_data_port = null;
        }
        private int? __pbn__firing_data_port;

        [global::ProtoBuf.ProtoMember(8)]
        public int positioning_data_port
        {
            get { return __pbn__positioning_data_port.GetValueOrDefault(); }
            set { __pbn__positioning_data_port = value; }
        }
        public bool ShouldSerializepositioning_data_port()
        {
            return __pbn__positioning_data_port != null;
        }
        public void Resetpositioning_data_port()
        {
            __pbn__positioning_data_port = null;
        }
        private int? __pbn__positioning_data_port;

        [global::ProtoBuf.ProtoMember(9)]
        public bool use_sensor_sync
        {
            get { return __pbn__use_sensor_sync.GetValueOrDefault(); }
            set { __pbn__use_sensor_sync = value; }
        }
        public bool ShouldSerializeuse_sensor_sync()
        {
            return __pbn__use_sensor_sync != null;
        }
        public void Resetuse_sensor_sync()
        {
            __pbn__use_sensor_sync = null;
        }
        private bool? __pbn__use_sensor_sync;

        [global::ProtoBuf.ProtoMember(10)]
        public double max_range
        {
            get { return __pbn__max_range.GetValueOrDefault(); }
            set { __pbn__max_range = value; }
        }
        public bool ShouldSerializemax_range()
        {
            return __pbn__max_range != null;
        }
        public void Resetmax_range()
        {
            __pbn__max_range = null;
        }
        private double? __pbn__max_range;

        [global::ProtoBuf.ProtoMember(11)]
        public double min_range
        {
            get { return __pbn__min_range.GetValueOrDefault(); }
            set { __pbn__min_range = value; }
        }
        public bool ShouldSerializemin_range()
        {
            return __pbn__min_range != null;
        }
        public void Resetmin_range()
        {
            __pbn__min_range = null;
        }
        private double? __pbn__min_range;

        [global::ProtoBuf.ProtoMember(12)]
        public double max_angle
        {
            get { return __pbn__max_angle.GetValueOrDefault(); }
            set { __pbn__max_angle = value; }
        }
        public bool ShouldSerializemax_angle()
        {
            return __pbn__max_angle != null;
        }
        public void Resetmax_angle()
        {
            __pbn__max_angle = null;
        }
        private double? __pbn__max_angle;

        [global::ProtoBuf.ProtoMember(13)]
        public double min_angle
        {
            get { return __pbn__min_angle.GetValueOrDefault(); }
            set { __pbn__min_angle = value; }
        }
        public bool ShouldSerializemin_angle()
        {
            return __pbn__min_angle != null;
        }
        public void Resetmin_angle()
        {
            __pbn__min_angle = null;
        }
        private double? __pbn__min_angle;

        [global::ProtoBuf.ProtoMember(14)]
        public double view_direction
        {
            get { return __pbn__view_direction.GetValueOrDefault(); }
            set { __pbn__view_direction = value; }
        }
        public bool ShouldSerializeview_direction()
        {
            return __pbn__view_direction != null;
        }
        public void Resetview_direction()
        {
            __pbn__view_direction = null;
        }
        private double? __pbn__view_direction;

        [global::ProtoBuf.ProtoMember(15)]
        public double view_width
        {
            get { return __pbn__view_width.GetValueOrDefault(); }
            set { __pbn__view_width = value; }
        }
        public bool ShouldSerializeview_width()
        {
            return __pbn__view_width != null;
        }
        public void Resetview_width()
        {
            __pbn__view_width = null;
        }
        private double? __pbn__view_width;

        [global::ProtoBuf.ProtoMember(16)]
        public bool calibration_online
        {
            get { return __pbn__calibration_online.GetValueOrDefault(); }
            set { __pbn__calibration_online = value; }
        }
        public bool ShouldSerializecalibration_online()
        {
            return __pbn__calibration_online != null;
        }
        public void Resetcalibration_online()
        {
            __pbn__calibration_online = null;
        }
        private bool? __pbn__calibration_online;

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.ComponentModel.DefaultValue("")]
        public string calibration_file
        {
            get { return __pbn__calibration_file ?? ""; }
            set { __pbn__calibration_file = value; }
        }
        public bool ShouldSerializecalibration_file()
        {
            return __pbn__calibration_file != null;
        }
        public void Resetcalibration_file()
        {
            __pbn__calibration_file = null;
        }
        private string __pbn__calibration_file;

        [global::ProtoBuf.ProtoMember(18)]
        public bool organized
        {
            get { return __pbn__organized.GetValueOrDefault(); }
            set { __pbn__organized = value; }
        }
        public bool ShouldSerializeorganized()
        {
            return __pbn__organized != null;
        }
        public void Resetorganized()
        {
            __pbn__organized = null;
        }
        private bool? __pbn__organized;

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.ComponentModel.DefaultValue("")]
        public string convert_channel_name
        {
            get { return __pbn__convert_channel_name ?? ""; }
            set { __pbn__convert_channel_name = value; }
        }
        public bool ShouldSerializeconvert_channel_name()
        {
            return __pbn__convert_channel_name != null;
        }
        public void Resetconvert_channel_name()
        {
            __pbn__convert_channel_name = null;
        }
        private string __pbn__convert_channel_name;

        [global::ProtoBuf.ProtoMember(20)]
        public int npackets
        {
            get { return __pbn__npackets.GetValueOrDefault(); }
            set { __pbn__npackets = value; }
        }
        public bool ShouldSerializenpackets()
        {
            return __pbn__npackets != null;
        }
        public void Resetnpackets()
        {
            __pbn__npackets = null;
        }
        private int? __pbn__npackets;

        [global::ProtoBuf.ProtoMember(23)]
        public bool use_gps_time
        {
            get { return __pbn__use_gps_time.GetValueOrDefault(); }
            set { __pbn__use_gps_time = value; }
        }
        public bool ShouldSerializeuse_gps_time()
        {
            return __pbn__use_gps_time != null;
        }
        public void Resetuse_gps_time()
        {
            __pbn__use_gps_time = null;
        }
        private bool? __pbn__use_gps_time;

        [global::ProtoBuf.ProtoMember(24)]
        public bool use_poll_sync
        {
            get { return __pbn__use_poll_sync.GetValueOrDefault(); }
            set { __pbn__use_poll_sync = value; }
        }
        public bool ShouldSerializeuse_poll_sync()
        {
            return __pbn__use_poll_sync != null;
        }
        public void Resetuse_poll_sync()
        {
            __pbn__use_poll_sync = null;
        }
        private bool? __pbn__use_poll_sync;

        [global::ProtoBuf.ProtoMember(25)]
        public bool is_main_frame
        {
            get { return __pbn__is_main_frame.GetValueOrDefault(); }
            set { __pbn__is_main_frame = value; }
        }
        public bool ShouldSerializeis_main_frame()
        {
            return __pbn__is_main_frame != null;
        }
        public void Resetis_main_frame()
        {
            __pbn__is_main_frame = null;
        }
        private bool? __pbn__is_main_frame;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class FusionConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public FusionConfig()
        {
            input_channel = new global::System.Collections.Generic.List<string>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public uint max_interval_ms
        {
            get { return __pbn__max_interval_ms.GetValueOrDefault(); }
            set { __pbn__max_interval_ms = value; }
        }
        public bool ShouldSerializemax_interval_ms()
        {
            return __pbn__max_interval_ms != null;
        }
        public void Resetmax_interval_ms()
        {
            __pbn__max_interval_ms = null;
        }
        private uint? __pbn__max_interval_ms;

        [global::ProtoBuf.ProtoMember(2)]
        public bool drop_expired_data
        {
            get { return __pbn__drop_expired_data.GetValueOrDefault(); }
            set { __pbn__drop_expired_data = value; }
        }
        public bool ShouldSerializedrop_expired_data()
        {
            return __pbn__drop_expired_data != null;
        }
        public void Resetdrop_expired_data()
        {
            __pbn__drop_expired_data = null;
        }
        private bool? __pbn__drop_expired_data;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue("")]
        public string fusion_channel
        {
            get { return __pbn__fusion_channel ?? ""; }
            set { __pbn__fusion_channel = value; }
        }
        public bool ShouldSerializefusion_channel()
        {
            return __pbn__fusion_channel != null;
        }
        public void Resetfusion_channel()
        {
            __pbn__fusion_channel = null;
        }
        private string __pbn__fusion_channel;

        [global::ProtoBuf.ProtoMember(4)]
        public global::System.Collections.Generic.List<string> input_channel { get; private set; }

        [global::ProtoBuf.ProtoMember(5)]
        public float wait_time_s
        {
            get { return __pbn__wait_time_s.GetValueOrDefault(); }
            set { __pbn__wait_time_s = value; }
        }
        public bool ShouldSerializewait_time_s()
        {
            return __pbn__wait_time_s != null;
        }
        public void Resetwait_time_s()
        {
            __pbn__wait_time_s = null;
        }
        private float? __pbn__wait_time_s;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class CompensatorConfig : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public CompensatorConfig()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue("")]
        public string output_channel
        {
            get { return __pbn__output_channel ?? ""; }
            set { __pbn__output_channel = value; }
        }
        public bool ShouldSerializeoutput_channel()
        {
            return __pbn__output_channel != null;
        }
        public void Resetoutput_channel()
        {
            __pbn__output_channel = null;
        }
        private string __pbn__output_channel;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0.02f)]
        public float transform_query_timeout
        {
            get { return __pbn__transform_query_timeout ?? 0.02f; }
            set { __pbn__transform_query_timeout = value; }
        }
        public bool ShouldSerializetransform_query_timeout()
        {
            return __pbn__transform_query_timeout != null;
        }
        public void Resettransform_query_timeout()
        {
            __pbn__transform_query_timeout = null;
        }
        private float? __pbn__transform_query_timeout;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(@"world")]
        public string world_frame_id
        {
            get { return __pbn__world_frame_id ?? @"world"; }
            set { __pbn__world_frame_id = value; }
        }
        public bool ShouldSerializeworld_frame_id()
        {
            return __pbn__world_frame_id != null;
        }
        public void Resetworld_frame_id()
        {
            __pbn__world_frame_id = null;
        }
        private string __pbn__world_frame_id;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue("")]
        public string target_frame_id
        {
            get { return __pbn__target_frame_id ?? ""; }
            set { __pbn__target_frame_id = value; }
        }
        public bool ShouldSerializetarget_frame_id()
        {
            return __pbn__target_frame_id != null;
        }
        public void Resettarget_frame_id()
        {
            __pbn__target_frame_id = null;
        }
        private string __pbn__target_frame_id;

        [global::ProtoBuf.ProtoMember(5)]
        public uint point_cloud_size
        {
            get { return __pbn__point_cloud_size.GetValueOrDefault(); }
            set { __pbn__point_cloud_size = value; }
        }
        public bool ShouldSerializepoint_cloud_size()
        {
            return __pbn__point_cloud_size != null;
        }
        public void Resetpoint_cloud_size()
        {
            __pbn__point_cloud_size = null;
        }
        private uint? __pbn__point_cloud_size;

    }

}

#pragma warning restore 0612, 1591, 3021
