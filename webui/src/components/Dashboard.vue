<template>
  <div class="pr-6 py-6 mr-12 h-screen md:h-auto">
    <div class="text-3xl text-amber-950 font-bold mb-8">
      <h1>Dashboard</h1>
    </div>

    <div class="overflow-y-auto h-full">
      <div>
        <label class="input input-bordered flex items-center gap-2 w-2/5 mb-12">
          <input type="text" class="grow" placeholder="Search" />
          <svg xmlns="http://www.w3.org/2000/svg" viewBox="0 0 16 16" fill="currentColor" class="h-4 w-4 opacity-70">
            <path fill-rule="evenodd"
              d="M9.965 11.026a5 5 0 1 1 1.06-1.06l2.755 2.754a.75.75 0 1 1-1.06 1.06l-2.755-2.754ZM10.5 7a3.5 3.5 0 1 1-7 0 3.5 3.5 0 0 1 7 0Z"
              clip-rule="evenodd" />
          </svg>
        </label>
      </div>
      
      <div class="grid grid-cols-2 md:grid-cols-3 gap-4">
        <div v-for="file in files" :key="file.id">
          <Card :file="file" />
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import Card from './DashboardCard.vue'
import instance from '../api/agent.ts'
import { useUserStore } from '../stores/user'
import { computed, ref, onMounted } from 'vue'

const userStore = useUserStore()
const user = computed(() => userStore.user)
const files = ref([])

const getFiles = async () => {
  try {
    const response = await instance.get('/all-files');
    files.value = response.data;
    console.log(response.data);
  } catch (error) {
    console.error(error);
  }
}

onMounted(() => {
  getFiles();
})
</script>
