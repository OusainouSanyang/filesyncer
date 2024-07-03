<template>
  <div class="flex h-screen overflow-hidden">
    <div class="basis-1/4 h-full overflow-y-auto">
      <SideNav />
    </div>
    <div class="basis-3/4 h-full overflow-y-auto">
      <RouterView />
    </div>
  </div>
</template>



<script setup>
import SideNav from '../components/SideNav.vue'
import { RouterView } from 'vue-router'
</script>
