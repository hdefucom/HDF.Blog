<template>
  <div id="info">

    <img
      height='100'
      src="/logo.png"
    />
    <p class="title">德芙-纵享丝滑</p>
    <div>
      <a
        href='https://gitee.com/hdefucom'
        target="_blank"
      ><img
          src='/gitee.png'
          alt='star'
          height='50'
        /></a>
      <a
        href='https://github.com/hdefucom'
        target="_blank"
      ><img
          src='/github.png'
          alt='star'
          height='50'
        /></a>
    </div>
  </div>

</template>

<script>

export default {
  name: 'Info',
  props: {
  },
  data() {
    return {

    }
  }
}
</script>
<style scoped>
#info {
  text-align: center;
}
img {
  margin: 10px;
}
.title {
  font-size: 30px;
}
.logo {
  height: 100px;
}
</style>