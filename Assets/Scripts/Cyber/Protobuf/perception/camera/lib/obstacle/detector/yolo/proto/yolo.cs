// <auto-generated>
//   This file was generated by a tool; you should avoid making direct changes.
//   Consider using 'partial classes' to extend these types
//   Input: yolo.proto
// </auto-generated>

#pragma warning disable 0612, 1591, 3021
namespace apollo.perception.camera.yolo
{

    [global::ProtoBuf.ProtoContract()]
    public partial class YoloParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public YoloParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public ModelParam model_param { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public NetworkParam net_param { get; set; }

        [global::ProtoBuf.ProtoMember(3)]
        public NMSParam nms_param { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class ModelParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public ModelParam()
        {
            dimension_statistics = new global::System.Collections.Generic.List<DimensionStatistics>();
            bbox_statistics = new global::System.Collections.Generic.List<BBoxStatistics>();
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"yolo-2d")]
        public string model_name
        {
            get { return __pbn__model_name ?? @"yolo-2d"; }
            set { __pbn__model_name = value; }
        }
        public bool ShouldSerializemodel_name()
        {
            return __pbn__model_name != null;
        }
        public void Resetmodel_name()
        {
            __pbn__model_name = null;
        }
        private string __pbn__model_name;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(@"caffe.pt")]
        public string proto_file
        {
            get { return __pbn__proto_file ?? @"caffe.pt"; }
            set { __pbn__proto_file = value; }
        }
        public bool ShouldSerializeproto_file()
        {
            return __pbn__proto_file != null;
        }
        public void Resetproto_file()
        {
            __pbn__proto_file = null;
        }
        private string __pbn__proto_file;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(@"caffe.md")]
        public string weight_file
        {
            get { return __pbn__weight_file ?? @"caffe.md"; }
            set { __pbn__weight_file = value; }
        }
        public bool ShouldSerializeweight_file()
        {
            return __pbn__weight_file != null;
        }
        public void Resetweight_file()
        {
            __pbn__weight_file = null;
        }
        private string __pbn__weight_file;

        [global::ProtoBuf.ProtoMember(21)]
        [global::System.ComponentModel.DefaultValue(@"caffe.pt")]
        public string stage1_pt
        {
            get { return __pbn__stage1_pt ?? @"caffe.pt"; }
            set { __pbn__stage1_pt = value; }
        }
        public bool ShouldSerializestage1_pt()
        {
            return __pbn__stage1_pt != null;
        }
        public void Resetstage1_pt()
        {
            __pbn__stage1_pt = null;
        }
        private string __pbn__stage1_pt;

        [global::ProtoBuf.ProtoMember(22)]
        [global::System.ComponentModel.DefaultValue(@"caffe.md")]
        public string stage1_md
        {
            get { return __pbn__stage1_md ?? @"caffe.md"; }
            set { __pbn__stage1_md = value; }
        }
        public bool ShouldSerializestage1_md()
        {
            return __pbn__stage1_md != null;
        }
        public void Resetstage1_md()
        {
            __pbn__stage1_md = null;
        }
        private string __pbn__stage1_md;

        [global::ProtoBuf.ProtoMember(23)]
        [global::System.ComponentModel.DefaultValue(@"caffe.pt")]
        public string stage2_pt
        {
            get { return __pbn__stage2_pt ?? @"caffe.pt"; }
            set { __pbn__stage2_pt = value; }
        }
        public bool ShouldSerializestage2_pt()
        {
            return __pbn__stage2_pt != null;
        }
        public void Resetstage2_pt()
        {
            __pbn__stage2_pt = null;
        }
        private string __pbn__stage2_pt;

        [global::ProtoBuf.ProtoMember(24)]
        [global::System.ComponentModel.DefaultValue(@"caffe.md")]
        public string stage2_md
        {
            get { return __pbn__stage2_md ?? @"caffe.md"; }
            set { __pbn__stage2_md = value; }
        }
        public bool ShouldSerializestage2_md()
        {
            return __pbn__stage2_md != null;
        }
        public void Resetstage2_md()
        {
            __pbn__stage2_md = null;
        }
        private string __pbn__stage2_md;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(@"anchors.txt")]
        public string anchors_file
        {
            get { return __pbn__anchors_file ?? @"anchors.txt"; }
            set { __pbn__anchors_file = value; }
        }
        public bool ShouldSerializeanchors_file()
        {
            return __pbn__anchors_file != null;
        }
        public void Resetanchors_file()
        {
            __pbn__anchors_file = null;
        }
        private string __pbn__anchors_file;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(@"types.txt")]
        public string types_file
        {
            get { return __pbn__types_file ?? @"types.txt"; }
            set { __pbn__types_file = value; }
        }
        public bool ShouldSerializetypes_file()
        {
            return __pbn__types_file != null;
        }
        public void Resettypes_file()
        {
            __pbn__types_file = null;
        }
        private string __pbn__types_file;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(@"feature.pt")]
        public string feature_file
        {
            get { return __pbn__feature_file ?? @"feature.pt"; }
            set { __pbn__feature_file = value; }
        }
        public bool ShouldSerializefeature_file()
        {
            return __pbn__feature_file != null;
        }
        public void Resetfeature_file()
        {
            __pbn__feature_file = null;
        }
        private string __pbn__feature_file;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(0.288889f)]
        public float offset_ratio
        {
            get { return __pbn__offset_ratio ?? 0.288889f; }
            set { __pbn__offset_ratio = value; }
        }
        public bool ShouldSerializeoffset_ratio()
        {
            return __pbn__offset_ratio != null;
        }
        public void Resetoffset_ratio()
        {
            __pbn__offset_ratio = null;
        }
        private float? __pbn__offset_ratio;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(0.711111f)]
        public float cropped_ratio
        {
            get { return __pbn__cropped_ratio ?? 0.711111f; }
            set { __pbn__cropped_ratio = value; }
        }
        public bool ShouldSerializecropped_ratio()
        {
            return __pbn__cropped_ratio != null;
        }
        public void Resetcropped_ratio()
        {
            __pbn__cropped_ratio = null;
        }
        private float? __pbn__cropped_ratio;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue(1440)]
        public int resized_width
        {
            get { return __pbn__resized_width ?? 1440; }
            set { __pbn__resized_width = value; }
        }
        public bool ShouldSerializeresized_width()
        {
            return __pbn__resized_width != null;
        }
        public void Resetresized_width()
        {
            __pbn__resized_width = null;
        }
        private int? __pbn__resized_width;

        [global::ProtoBuf.ProtoMember(15)]
        [global::System.ComponentModel.DefaultValue(32)]
        public int aligned_pixel
        {
            get { return __pbn__aligned_pixel ?? 32; }
            set { __pbn__aligned_pixel = value; }
        }
        public bool ShouldSerializealigned_pixel()
        {
            return __pbn__aligned_pixel != null;
        }
        public void Resetaligned_pixel()
        {
            __pbn__aligned_pixel = null;
        }
        private int? __pbn__aligned_pixel;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(0.1f)]
        public float confidence_threshold
        {
            get { return __pbn__confidence_threshold ?? 0.1f; }
            set { __pbn__confidence_threshold = value; }
        }
        public bool ShouldSerializeconfidence_threshold()
        {
            return __pbn__confidence_threshold != null;
        }
        public void Resetconfidence_threshold()
        {
            __pbn__confidence_threshold = null;
        }
        private float? __pbn__confidence_threshold;

        [global::ProtoBuf.ProtoMember(33)]
        [global::System.ComponentModel.DefaultValue(0.5f)]
        public float light_vis_conf_threshold
        {
            get { return __pbn__light_vis_conf_threshold ?? 0.5f; }
            set { __pbn__light_vis_conf_threshold = value; }
        }
        public bool ShouldSerializelight_vis_conf_threshold()
        {
            return __pbn__light_vis_conf_threshold != null;
        }
        public void Resetlight_vis_conf_threshold()
        {
            __pbn__light_vis_conf_threshold = null;
        }
        private float? __pbn__light_vis_conf_threshold;

        [global::ProtoBuf.ProtoMember(34)]
        [global::System.ComponentModel.DefaultValue(0.5f)]
        public float light_swt_conf_threshold
        {
            get { return __pbn__light_swt_conf_threshold ?? 0.5f; }
            set { __pbn__light_swt_conf_threshold = value; }
        }
        public bool ShouldSerializelight_swt_conf_threshold()
        {
            return __pbn__light_swt_conf_threshold != null;
        }
        public void Resetlight_swt_conf_threshold()
        {
            __pbn__light_swt_conf_threshold = null;
        }
        private float? __pbn__light_swt_conf_threshold;

        [global::ProtoBuf.ProtoMember(25)]
        [global::System.ComponentModel.DefaultValue(0.1f)]
        public float roi_conf_threshold
        {
            get { return __pbn__roi_conf_threshold ?? 0.1f; }
            set { __pbn__roi_conf_threshold = value; }
        }
        public bool ShouldSerializeroi_conf_threshold()
        {
            return __pbn__roi_conf_threshold != null;
        }
        public void Resetroi_conf_threshold()
        {
            __pbn__roi_conf_threshold = null;
        }
        private float? __pbn__roi_conf_threshold;

        [global::ProtoBuf.ProtoMember(26)]
        [global::System.ComponentModel.DefaultValue(0.5f)]
        public float box_conf_threshold
        {
            get { return __pbn__box_conf_threshold ?? 0.5f; }
            set { __pbn__box_conf_threshold = value; }
        }
        public bool ShouldSerializebox_conf_threshold()
        {
            return __pbn__box_conf_threshold != null;
        }
        public void Resetbox_conf_threshold()
        {
            __pbn__box_conf_threshold = null;
        }
        private float? __pbn__box_conf_threshold;

        [global::ProtoBuf.ProtoMember(27)]
        [global::System.ComponentModel.DefaultValue(0.4f)]
        public float stage2_nms_threshold
        {
            get { return __pbn__stage2_nms_threshold ?? 0.4f; }
            set { __pbn__stage2_nms_threshold = value; }
        }
        public bool ShouldSerializestage2_nms_threshold()
        {
            return __pbn__stage2_nms_threshold != null;
        }
        public void Resetstage2_nms_threshold()
        {
            __pbn__stage2_nms_threshold = null;
        }
        private float? __pbn__stage2_nms_threshold;

        [global::ProtoBuf.ProtoMember(9)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float min_2d_height
        {
            get { return __pbn__min_2d_height ?? 0f; }
            set { __pbn__min_2d_height = value; }
        }
        public bool ShouldSerializemin_2d_height()
        {
            return __pbn__min_2d_height != null;
        }
        public void Resetmin_2d_height()
        {
            __pbn__min_2d_height = null;
        }
        private float? __pbn__min_2d_height;

        [global::ProtoBuf.ProtoMember(30)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float min_3d_height
        {
            get { return __pbn__min_3d_height ?? 0f; }
            set { __pbn__min_3d_height = value; }
        }
        public bool ShouldSerializemin_3d_height()
        {
            return __pbn__min_3d_height != null;
        }
        public void Resetmin_3d_height()
        {
            __pbn__min_3d_height = null;
        }
        private float? __pbn__min_3d_height;

        [global::ProtoBuf.ProtoMember(31)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float min_3d_width
        {
            get { return __pbn__min_3d_width ?? 0f; }
            set { __pbn__min_3d_width = value; }
        }
        public bool ShouldSerializemin_3d_width()
        {
            return __pbn__min_3d_width != null;
        }
        public void Resetmin_3d_width()
        {
            __pbn__min_3d_width = null;
        }
        private float? __pbn__min_3d_width;

        [global::ProtoBuf.ProtoMember(32)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float min_3d_length
        {
            get { return __pbn__min_3d_length ?? 0f; }
            set { __pbn__min_3d_length = value; }
        }
        public bool ShouldSerializemin_3d_length()
        {
            return __pbn__min_3d_length != null;
        }
        public void Resetmin_3d_length()
        {
            __pbn__min_3d_length = null;
        }
        private float? __pbn__min_3d_length;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(@"./")]
        public string calibratetable_root
        {
            get { return __pbn__calibratetable_root ?? @"./"; }
            set { __pbn__calibratetable_root = value; }
        }
        public bool ShouldSerializecalibratetable_root()
        {
            return __pbn__calibratetable_root != null;
        }
        public void Resetcalibratetable_root()
        {
            __pbn__calibratetable_root = null;
        }
        private string __pbn__calibratetable_root;

        [global::ProtoBuf.ProtoMember(12)]
        [global::System.ComponentModel.DefaultValue(@"CaffeNet")]
        public string model_type
        {
            get { return __pbn__model_type ?? @"CaffeNet"; }
            set { __pbn__model_type = value; }
        }
        public bool ShouldSerializemodel_type()
        {
            return __pbn__model_type != null;
        }
        public void Resetmodel_type()
        {
            __pbn__model_type = null;
        }
        private string __pbn__model_type;

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue(1)]
        public int ori_cycle
        {
            get { return __pbn__ori_cycle ?? 1; }
            set { __pbn__ori_cycle = value; }
        }
        public bool ShouldSerializeori_cycle()
        {
            return __pbn__ori_cycle != null;
        }
        public void Resetori_cycle()
        {
            __pbn__ori_cycle = null;
        }
        private int? __pbn__ori_cycle;

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool per_cls_reg
        {
            get { return __pbn__per_cls_reg ?? false; }
            set { __pbn__per_cls_reg = value; }
        }
        public bool ShouldSerializeper_cls_reg()
        {
            return __pbn__per_cls_reg != null;
        }
        public void Resetper_cls_reg()
        {
            __pbn__per_cls_reg = null;
        }
        private bool? __pbn__per_cls_reg;

        [global::ProtoBuf.ProtoMember(18)]
        public global::System.Collections.Generic.List<DimensionStatistics> dimension_statistics { get; private set; }

        [global::ProtoBuf.ProtoMember(19)]
        public global::System.Collections.Generic.List<BBoxStatistics> bbox_statistics { get; private set; }

        [global::ProtoBuf.ProtoMember(20)]
        [global::System.ComponentModel.DefaultValue(@"expand.txt")]
        public string expand_file
        {
            get { return __pbn__expand_file ?? @"expand.txt"; }
            set { __pbn__expand_file = value; }
        }
        public bool ShouldSerializeexpand_file()
        {
            return __pbn__expand_file != null;
        }
        public void Resetexpand_file()
        {
            __pbn__expand_file = null;
        }
        private string __pbn__expand_file;

        [global::ProtoBuf.ProtoMember(41)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool with_box3d
        {
            get { return __pbn__with_box3d ?? false; }
            set { __pbn__with_box3d = value; }
        }
        public bool ShouldSerializewith_box3d()
        {
            return __pbn__with_box3d != null;
        }
        public void Resetwith_box3d()
        {
            __pbn__with_box3d = null;
        }
        private bool? __pbn__with_box3d;

        [global::ProtoBuf.ProtoMember(42)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool with_frbox
        {
            get { return __pbn__with_frbox ?? false; }
            set { __pbn__with_frbox = value; }
        }
        public bool ShouldSerializewith_frbox()
        {
            return __pbn__with_frbox != null;
        }
        public void Resetwith_frbox()
        {
            __pbn__with_frbox = null;
        }
        private bool? __pbn__with_frbox;

        [global::ProtoBuf.ProtoMember(43)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool with_lights
        {
            get { return __pbn__with_lights ?? false; }
            set { __pbn__with_lights = value; }
        }
        public bool ShouldSerializewith_lights()
        {
            return __pbn__with_lights != null;
        }
        public void Resetwith_lights()
        {
            __pbn__with_lights = null;
        }
        private bool? __pbn__with_lights;

        [global::ProtoBuf.ProtoMember(44)]
        [global::System.ComponentModel.DefaultValue(false)]
        public bool with_ratios
        {
            get { return __pbn__with_ratios ?? false; }
            set { __pbn__with_ratios = value; }
        }
        public bool ShouldSerializewith_ratios()
        {
            return __pbn__with_ratios != null;
        }
        public void Resetwith_ratios()
        {
            __pbn__with_ratios = null;
        }
        private bool? __pbn__with_ratios;

        [global::ProtoBuf.ProtoMember(46)]
        [global::System.ComponentModel.DefaultValue(0)]
        public int num_areas
        {
            get { return __pbn__num_areas ?? 0; }
            set { __pbn__num_areas = value; }
        }
        public bool ShouldSerializenum_areas()
        {
            return __pbn__num_areas != null;
        }
        public void Resetnum_areas()
        {
            __pbn__num_areas = null;
        }
        private int? __pbn__num_areas;

        [global::ProtoBuf.ProtoMember(45)]
        [global::System.ComponentModel.DefaultValue(0.01f)]
        public float border_ratio
        {
            get { return __pbn__border_ratio ?? 0.01f; }
            set { __pbn__border_ratio = value; }
        }
        public bool ShouldSerializeborder_ratio()
        {
            return __pbn__border_ratio != null;
        }
        public void Resetborder_ratio()
        {
            __pbn__border_ratio = null;
        }
        private float? __pbn__border_ratio;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NetworkParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public NetworkParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"loc_pred")]
        public string loc_blob
        {
            get { return __pbn__loc_blob ?? @"loc_pred"; }
            set { __pbn__loc_blob = value; }
        }
        public bool ShouldSerializeloc_blob()
        {
            return __pbn__loc_blob != null;
        }
        public void Resetloc_blob()
        {
            __pbn__loc_blob = null;
        }
        private string __pbn__loc_blob;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(@"obj_pred")]
        public string obj_blob
        {
            get { return __pbn__obj_blob ?? @"obj_pred"; }
            set { __pbn__obj_blob = value; }
        }
        public bool ShouldSerializeobj_blob()
        {
            return __pbn__obj_blob != null;
        }
        public void Resetobj_blob()
        {
            __pbn__obj_blob = null;
        }
        private string __pbn__obj_blob;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(@"cls_pred")]
        public string cls_blob
        {
            get { return __pbn__cls_blob ?? @"cls_pred"; }
            set { __pbn__cls_blob = value; }
        }
        public bool ShouldSerializecls_blob()
        {
            return __pbn__cls_blob != null;
        }
        public void Resetcls_blob()
        {
            __pbn__cls_blob = null;
        }
        private string __pbn__cls_blob;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(@"ori_pred")]
        public string ori_blob
        {
            get { return __pbn__ori_blob ?? @"ori_pred"; }
            set { __pbn__ori_blob = value; }
        }
        public bool ShouldSerializeori_blob()
        {
            return __pbn__ori_blob != null;
        }
        public void Resetori_blob()
        {
            __pbn__ori_blob = null;
        }
        private string __pbn__ori_blob;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(@"dim_pred")]
        public string dim_blob
        {
            get { return __pbn__dim_blob ?? @"dim_pred"; }
            set { __pbn__dim_blob = value; }
        }
        public bool ShouldSerializedim_blob()
        {
            return __pbn__dim_blob != null;
        }
        public void Resetdim_blob()
        {
            __pbn__dim_blob = null;
        }
        private string __pbn__dim_blob;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(@"lof_pred")]
        public string lof_blob
        {
            get { return __pbn__lof_blob ?? @"lof_pred"; }
            set { __pbn__lof_blob = value; }
        }
        public bool ShouldSerializelof_blob()
        {
            return __pbn__lof_blob != null;
        }
        public void Resetlof_blob()
        {
            __pbn__lof_blob = null;
        }
        private string __pbn__lof_blob;

        [global::ProtoBuf.ProtoMember(7)]
        [global::System.ComponentModel.DefaultValue(@"lor_pred")]
        public string lor_blob
        {
            get { return __pbn__lor_blob ?? @"lor_pred"; }
            set { __pbn__lor_blob = value; }
        }
        public bool ShouldSerializelor_blob()
        {
            return __pbn__lor_blob != null;
        }
        public void Resetlor_blob()
        {
            __pbn__lor_blob = null;
        }
        private string __pbn__lor_blob;

        [global::ProtoBuf.ProtoMember(8)]
        [global::System.ComponentModel.DefaultValue(@"data")]
        public string input_blob
        {
            get { return __pbn__input_blob ?? @"data"; }
            set { __pbn__input_blob = value; }
        }
        public bool ShouldSerializeinput_blob()
        {
            return __pbn__input_blob != null;
        }
        public void Resetinput_blob()
        {
            __pbn__input_blob = null;
        }
        private string __pbn__input_blob;

        [global::ProtoBuf.ProtoMember(10)]
        [global::System.ComponentModel.DefaultValue(@"rois_pred")]
        public string rois_blob
        {
            get { return __pbn__rois_blob ?? @"rois_pred"; }
            set { __pbn__rois_blob = value; }
        }
        public bool ShouldSerializerois_blob()
        {
            return __pbn__rois_blob != null;
        }
        public void Resetrois_blob()
        {
            __pbn__rois_blob = null;
        }
        private string __pbn__rois_blob;

        [global::ProtoBuf.ProtoMember(11)]
        [global::System.ComponentModel.DefaultValue(@"conv_feat")]
        public string feat_blob
        {
            get { return __pbn__feat_blob ?? @"conv_feat"; }
            set { __pbn__feat_blob = value; }
        }
        public bool ShouldSerializefeat_blob()
        {
            return __pbn__feat_blob != null;
        }
        public void Resetfeat_blob()
        {
            __pbn__feat_blob = null;
        }
        private string __pbn__feat_blob;

        [global::ProtoBuf.ProtoMember(13)]
        [global::System.ComponentModel.DefaultValue(@"box_pred")]
        public string box_blob
        {
            get { return __pbn__box_blob ?? @"box_pred"; }
            set { __pbn__box_blob = value; }
        }
        public bool ShouldSerializebox_blob()
        {
            return __pbn__box_blob != null;
        }
        public void Resetbox_blob()
        {
            __pbn__box_blob = null;
        }
        private string __pbn__box_blob;

        [global::ProtoBuf.ProtoMember(14)]
        [global::System.ComponentModel.DefaultValue(@"iou_pred")]
        public string iou_blob
        {
            get { return __pbn__iou_blob ?? @"iou_pred"; }
            set { __pbn__iou_blob = value; }
        }
        public bool ShouldSerializeiou_blob()
        {
            return __pbn__iou_blob != null;
        }
        public void Resetiou_blob()
        {
            __pbn__iou_blob = null;
        }
        private string __pbn__iou_blob;

        [global::ProtoBuf.ProtoMember(15)]
        [global::System.ComponentModel.DefaultValue(@"brvis_pred")]
        public string brvis_blob
        {
            get { return __pbn__brvis_blob ?? @"brvis_pred"; }
            set { __pbn__brvis_blob = value; }
        }
        public bool ShouldSerializebrvis_blob()
        {
            return __pbn__brvis_blob != null;
        }
        public void Resetbrvis_blob()
        {
            __pbn__brvis_blob = null;
        }
        private string __pbn__brvis_blob;

        [global::ProtoBuf.ProtoMember(16)]
        [global::System.ComponentModel.DefaultValue(@"brswt_pred")]
        public string brswt_blob
        {
            get { return __pbn__brswt_blob ?? @"brswt_pred"; }
            set { __pbn__brswt_blob = value; }
        }
        public bool ShouldSerializebrswt_blob()
        {
            return __pbn__brswt_blob != null;
        }
        public void Resetbrswt_blob()
        {
            __pbn__brswt_blob = null;
        }
        private string __pbn__brswt_blob;

        [global::ProtoBuf.ProtoMember(17)]
        [global::System.ComponentModel.DefaultValue(@"ltvis_pred")]
        public string ltvis_blob
        {
            get { return __pbn__ltvis_blob ?? @"ltvis_pred"; }
            set { __pbn__ltvis_blob = value; }
        }
        public bool ShouldSerializeltvis_blob()
        {
            return __pbn__ltvis_blob != null;
        }
        public void Resetltvis_blob()
        {
            __pbn__ltvis_blob = null;
        }
        private string __pbn__ltvis_blob;

        [global::ProtoBuf.ProtoMember(18)]
        [global::System.ComponentModel.DefaultValue(@"ltswt_pred")]
        public string ltswt_blob
        {
            get { return __pbn__ltswt_blob ?? @"ltswt_pred"; }
            set { __pbn__ltswt_blob = value; }
        }
        public bool ShouldSerializeltswt_blob()
        {
            return __pbn__ltswt_blob != null;
        }
        public void Resetltswt_blob()
        {
            __pbn__ltswt_blob = null;
        }
        private string __pbn__ltswt_blob;

        [global::ProtoBuf.ProtoMember(19)]
        [global::System.ComponentModel.DefaultValue(@"rtvis_pred")]
        public string rtvis_blob
        {
            get { return __pbn__rtvis_blob ?? @"rtvis_pred"; }
            set { __pbn__rtvis_blob = value; }
        }
        public bool ShouldSerializertvis_blob()
        {
            return __pbn__rtvis_blob != null;
        }
        public void Resetrtvis_blob()
        {
            __pbn__rtvis_blob = null;
        }
        private string __pbn__rtvis_blob;

        [global::ProtoBuf.ProtoMember(20)]
        [global::System.ComponentModel.DefaultValue(@"rtswt_pred")]
        public string rtswt_blob
        {
            get { return __pbn__rtswt_blob ?? @"rtswt_pred"; }
            set { __pbn__rtswt_blob = value; }
        }
        public bool ShouldSerializertswt_blob()
        {
            return __pbn__rtswt_blob != null;
        }
        public void Resetrtswt_blob()
        {
            __pbn__rtswt_blob = null;
        }
        private string __pbn__rtswt_blob;

        [global::ProtoBuf.ProtoMember(23)]
        [global::System.ComponentModel.DefaultValue(@"area_id_pred")]
        public string area_id_blob
        {
            get { return __pbn__area_id_blob ?? @"area_id_pred"; }
            set { __pbn__area_id_blob = value; }
        }
        public bool ShouldSerializearea_id_blob()
        {
            return __pbn__area_id_blob != null;
        }
        public void Resetarea_id_blob()
        {
            __pbn__area_id_blob = null;
        }
        private string __pbn__area_id_blob;

        [global::ProtoBuf.ProtoMember(21)]
        [global::System.ComponentModel.DefaultValue(@"vis_pred")]
        public string visible_ratio_blob
        {
            get { return __pbn__visible_ratio_blob ?? @"vis_pred"; }
            set { __pbn__visible_ratio_blob = value; }
        }
        public bool ShouldSerializevisible_ratio_blob()
        {
            return __pbn__visible_ratio_blob != null;
        }
        public void Resetvisible_ratio_blob()
        {
            __pbn__visible_ratio_blob = null;
        }
        private string __pbn__visible_ratio_blob;

        [global::ProtoBuf.ProtoMember(22)]
        [global::System.ComponentModel.DefaultValue(@"cut_pred")]
        public string cut_off_ratio_blob
        {
            get { return __pbn__cut_off_ratio_blob ?? @"cut_pred"; }
            set { __pbn__cut_off_ratio_blob = value; }
        }
        public bool ShouldSerializecut_off_ratio_blob()
        {
            return __pbn__cut_off_ratio_blob != null;
        }
        public void Resetcut_off_ratio_blob()
        {
            __pbn__cut_off_ratio_blob = null;
        }
        private string __pbn__cut_off_ratio_blob;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class NMSParam : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public NMSParam()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(@"NormalNMS")]
        public string type
        {
            get { return __pbn__type ?? @"NormalNMS"; }
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
        private string __pbn__type;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0.4f)]
        public float threshold
        {
            get { return __pbn__threshold ?? 0.4f; }
            set { __pbn__threshold = value; }
        }
        public bool ShouldSerializethreshold()
        {
            return __pbn__threshold != null;
        }
        public void Resetthreshold()
        {
            __pbn__threshold = null;
        }
        private float? __pbn__threshold;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0.4f)]
        public float sigma
        {
            get { return __pbn__sigma ?? 0.4f; }
            set { __pbn__sigma = value; }
        }
        public bool ShouldSerializesigma()
        {
            return __pbn__sigma != null;
        }
        public void Resetsigma()
        {
            __pbn__sigma = null;
        }
        private float? __pbn__sigma;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(0.1f)]
        public float inter_cls_conf_thresh
        {
            get { return __pbn__inter_cls_conf_thresh ?? 0.1f; }
            set { __pbn__inter_cls_conf_thresh = value; }
        }
        public bool ShouldSerializeinter_cls_conf_thresh()
        {
            return __pbn__inter_cls_conf_thresh != null;
        }
        public void Resetinter_cls_conf_thresh()
        {
            __pbn__inter_cls_conf_thresh = null;
        }
        private float? __pbn__inter_cls_conf_thresh;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(1f)]
        public float inter_cls_nms_thresh
        {
            get { return __pbn__inter_cls_nms_thresh ?? 1f; }
            set { __pbn__inter_cls_nms_thresh = value; }
        }
        public bool ShouldSerializeinter_cls_nms_thresh()
        {
            return __pbn__inter_cls_nms_thresh != null;
        }
        public void Resetinter_cls_nms_thresh()
        {
            __pbn__inter_cls_nms_thresh = null;
        }
        private float? __pbn__inter_cls_nms_thresh;

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class BBoxStatistics : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public BBoxStatistics()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        public float[] mean { get; set; }

        [global::ProtoBuf.ProtoMember(2)]
        public float[] std { get; set; }

    }

    [global::ProtoBuf.ProtoContract()]
    public partial class DimensionStatistics : global::ProtoBuf.IExtensible
    {
        private global::ProtoBuf.IExtension __pbn__extensionData;
        global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
        {
            return global::ProtoBuf.Extensible.GetExtensionObject(ref __pbn__extensionData, createIfMissing);
        }
        public DimensionStatistics()
        {
            OnConstructor();
        }

        partial void OnConstructor();

        [global::ProtoBuf.ProtoMember(1)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float mean_h
        {
            get { return __pbn__mean_h ?? 0f; }
            set { __pbn__mean_h = value; }
        }
        public bool ShouldSerializemean_h()
        {
            return __pbn__mean_h != null;
        }
        public void Resetmean_h()
        {
            __pbn__mean_h = null;
        }
        private float? __pbn__mean_h;

        [global::ProtoBuf.ProtoMember(2)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float mean_w
        {
            get { return __pbn__mean_w ?? 0f; }
            set { __pbn__mean_w = value; }
        }
        public bool ShouldSerializemean_w()
        {
            return __pbn__mean_w != null;
        }
        public void Resetmean_w()
        {
            __pbn__mean_w = null;
        }
        private float? __pbn__mean_w;

        [global::ProtoBuf.ProtoMember(3)]
        [global::System.ComponentModel.DefaultValue(0f)]
        public float mean_l
        {
            get { return __pbn__mean_l ?? 0f; }
            set { __pbn__mean_l = value; }
        }
        public bool ShouldSerializemean_l()
        {
            return __pbn__mean_l != null;
        }
        public void Resetmean_l()
        {
            __pbn__mean_l = null;
        }
        private float? __pbn__mean_l;

        [global::ProtoBuf.ProtoMember(4)]
        [global::System.ComponentModel.DefaultValue(1f)]
        public float std_h
        {
            get { return __pbn__std_h ?? 1f; }
            set { __pbn__std_h = value; }
        }
        public bool ShouldSerializestd_h()
        {
            return __pbn__std_h != null;
        }
        public void Resetstd_h()
        {
            __pbn__std_h = null;
        }
        private float? __pbn__std_h;

        [global::ProtoBuf.ProtoMember(5)]
        [global::System.ComponentModel.DefaultValue(1f)]
        public float std_w
        {
            get { return __pbn__std_w ?? 1f; }
            set { __pbn__std_w = value; }
        }
        public bool ShouldSerializestd_w()
        {
            return __pbn__std_w != null;
        }
        public void Resetstd_w()
        {
            __pbn__std_w = null;
        }
        private float? __pbn__std_w;

        [global::ProtoBuf.ProtoMember(6)]
        [global::System.ComponentModel.DefaultValue(1f)]
        public float std_l
        {
            get { return __pbn__std_l ?? 1f; }
            set { __pbn__std_l = value; }
        }
        public bool ShouldSerializestd_l()
        {
            return __pbn__std_l != null;
        }
        public void Resetstd_l()
        {
            __pbn__std_l = null;
        }
        private float? __pbn__std_l;

    }

}

#pragma warning restore 0612, 1591, 3021
