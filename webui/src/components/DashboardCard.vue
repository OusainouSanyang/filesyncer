<template>
    <div class="max-w-sm p-6 bg-white border border-gray-200 rounded-lg shadow">
        <div class="flex gap-4">
            <div class="">
                <i class="bi bi-file-earmark text-2xl "></i>
            </div>
            <div>
                <h2 class=" font-semibold">{{ file.fileName }}</h2>
                <small><i class="bi bi-calendar4-week mx-2"></i>{{ new Date(file.dateUploaded).toLocaleDateString() }}</small>
            </div>
        </div>

        <div class=" border border-dashed border-amber-950 p-5 mt-6 rounded-lg">
            <h3>Description</h3>
            <p>Type: {{ file.fileType }}</p>
            <p>Size: {{ (file.fileSizeInBytes / 1024).toFixed(2) }} KB</p>
        </div>

        <div class="flex justify-end gap-6 mt-4">
            <div>
                <button @click="downloadFile">
                    <i class="bi bi-download text-2xl"></i>
                </button>
            </div>
        </div>

    </div>
</template>
  
  <script setup>
  import { defineProps } from 'vue'
  import instance from '../api/agent.ts'

  const props = defineProps({
    file: Object
  })

  const downloadFile = () => {
    const fileId = props.file.id;
    // Replace 'instance' with your Axios or fetch instance for API calls
    instance.get(`/download/${fileId}`, { responseType: 'blob' })
        .then(response => {
            const url = window.URL.createObjectURL(new Blob([response.data]));
            const link = document.createElement('a');
            link.href = url;
            link.setAttribute('download', props.file.fileName);
            document.body.appendChild(link);
            link.click();
            link.remove(); // Clean up
        })
        .catch(error => {
            console.error('Error downloading file:', error);
        });
}
  </script>
  

  