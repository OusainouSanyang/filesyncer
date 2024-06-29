<template>
  <div class="flex flex-row h-screen">
    <div class=" basis-1/5 h-screen">
      <SideNav />
    </div>
    <div class=" basis-2/3">
      <RouterView />
    </div>
  </div>
</template>

<script setup>
import SideNav from '../components/SideNav.vue'
import { RouterView } from 'vue-router'
</script>
