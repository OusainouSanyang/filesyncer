<template>
  <div class="diff aspect-[16/9]">
    <div class="">
      <div class="text-primary-content grid">
        <Dashboard/>
       <RouterView/>
      </div>
    </div>

    <div class="diff-item-2">
      <div class="bg-amber-950 grid place-content-start p-16">
        <img src="../assets//images/book-img.png" alt="Shoes"  class=" w-28 h-28 rounded-full mx-4 mb-6"/>
        <ul class="menu text-base-200 text-xl">
          <li>
            <RouterLink to="/home/dashboard">

              <a>
                <i class="bi bi-columns-gap"></i>
                Documents
              </a>
            </RouterLink>
          </li>
          <li>
            <a> <i class="bi bi-files"></i>My Documents</a>
          </li>
          <li>
            <a><i class="bi bi-box-arrow-right"></i> Log out</a>
          </li>
        </ul>
      </div>
    </div>
    <div class="diff-resizer"></div>
  </div>
</template>

<script setup>
import Dashboard from '../components/Dashboard.vue'
import { RouterLink, RouterView } from 'vue-router'
</script>
