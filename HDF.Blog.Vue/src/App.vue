<template>
  <Info />
  <Project />
  <Footer />
</template>

<script>
import Info from './components/Info.vue'
import Footer from './components/Footer.vue'
import Project from './components/Project.vue'

export default {
  name: 'App',
  components: {
    Info, Footer, Project
  }
}
</script>

<style >
body {
  margin: 0px;
  padding: 0px;
  height: 100%;
}
</style>