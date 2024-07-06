<template>
  <div class="flex h-screen overflow-hidden">
    <div class="h-full overflow-y-auto w-1/4">
      <SideNav />
    </div>
    <div class="h-full overflow-y-auto flex-1">
      <RouterView />
    </div>
  </div>
</template>



<script setup>
import { RouterView } from 'vue-router';
import SideNav from '../components/SideNav.vue';
</script>
