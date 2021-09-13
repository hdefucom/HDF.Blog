<template>
  <div id="footer">
    <a
      href="https://beian.miit.gov.cn/"
      target="_blank"
    >赣ICP备2021003855号-1</a>
  </div>

</template>

<script>
export default {
  name: 'Footer',
  props: {
  },
  data() {
    return {
    }
  }
}
</script>

<style scoped>
#footer {
  background-color: gray;
  height: 80px;
  text-align: center;
}

#footer a {
  color: #cfd2d4;
  text-decoration: none;
  line-height: 80px;
}
</style>