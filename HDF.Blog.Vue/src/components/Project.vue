<template>
  <div id="project">
    <!-- <script
      src='https://gitee.com/hdefucom/HDF.Blog/widget_preview'
      async
      defer
    ></script> -->
    <div id="osc-gitee-widget-tag"></div>
  </div>

</template>

<script>
export default {
  name: 'Project',
  props: {
  },
  data() {
    return {
    }
  },
  created() {
    this.$nextTick(() => {
      var s = document.createElement("script");
      s.setAttribute("src", "https://gitee.com/hdefucom/HDF/widget_preview");
      s.setAttribute("async", true);
      s.setAttribute("defer", true);
      let p = document.getElementById("project");
      p.appendChild(s);
    });
  }
}
</script>

<style scoped>
#project {
  width: 400px;
  margin: 50px auto;
  box-shadow: 0 2px 12px 0 rgba(0, 0, 0, 0.1);
}

.osc_pro_color {
  color: #4183c4 !important;
}
.osc_panel_color {
  background-color: #ffffff !important;
}
.osc_background_color {
  background-color: #ffffff !important;
}
.osc_border_color {
  border-color: #e3e9ed !important;
}
.osc_desc_color {
  color: #666666 !important;
}
.osc_link_color * {
  color: #9b9b9b !important;
}
</style>