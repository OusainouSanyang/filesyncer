<template>
    <div class="max-w-sm p-6 bg-white border border-gray-200 rounded-lg shadow">
        <div class="flex gap-4">
            <div class="">
                <i class="bi bi-file-earmark text-2xl "></i>
            </div>
            <div>
                <h2 class=" font-semibold">{{ file.fileName }}</h2>
                <small><i class="bi bi-calendar4-week mx-2"/>{{ new Date(file.dateUploaded).toLocaleDateString() }}</small>
            </div>
        </div>
        <div class=" border border-dashed border-amber-950 p-5 mt-6 rounded-lg">
            <h3>Description</h3>
<p>Type: {{ file.fileType }}</p>
        <p>Size: {{ (file.fileSizeInBytes / 1024).toFixed(2) }} KB</p>        </div>
        <div class="flex justify-end gap-6 mt-4">
            <div>
                <i class="bi bi-download text-2xl"></i>
            </div>
            <div>
                <i class="bi bi-trash3-fill text-red-700 text-2xl"></i>
            </div>
        </div>
    </div>
</template>

<!-- <template>
    <div class="card bg-base-100 shadow-xl p-4">
      <div class="card-body">
        <h2 class="card-title">{{ file.fileName }}</h2>
        <p>Uploaded on: {{ new Date(file.dateUploaded).toLocaleDateString() }}</p>
        <p>Type: {{ file.fileType }}</p>
        <p>Size: {{ (file.fileSizeInBytes / 1024).toFixed(2) }} KB</p>
      </div>
    </div>
  </template> -->
  
  <script setup>
  import { defineProps } from 'vue'
  
  const props = defineProps({
    file: Object
  })
  </script>
  
  <style scoped>
  .card {
    border: 1px solid #e5e7eb;
    border-radius: 0.5rem;
    overflow: hidden;
  }
  .card-body {
    padding: 1rem;
  }
  .card-title {
    font-size: 1.25rem;
    font-weight: 700;
    margin-bottom: 0.5rem;
  }
  </style>
  