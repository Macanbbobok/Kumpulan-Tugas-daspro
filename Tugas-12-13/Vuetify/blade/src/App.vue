<template>
  <div id="App">
 <img src ="./assets/logo unri.png" height="75" width="300">
 <webToolbar></webToolbar>
 <router-view/>
 <web-footer></web-footer>
 </div>
 </template>

<script>
import WebFooter from './components/WebFooter'
import WebToolbar from './components/WebToolbar'

export default {
  name: 'App',
  components: {WebFooter,WebToolbar
  }
}
</script>

<style>
#App {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;

}
</style>
