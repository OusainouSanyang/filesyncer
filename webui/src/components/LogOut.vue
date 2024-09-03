<template>
    <div class="flex justify-center mr-20 mt-24">
        <div
            class=" items-center bg-white border px-24 py-24 border-gray-200 rounded-lg shadow md:flex-row md:max-w-xl hover:bg-gray-100">

            <h5 class="mb-6 text-2xl font-bold tracking-tight text-center">You are logging out <i class="bi bi-emoji-smile-upside-down text-2xl"></i></h5>
            <div class=" flex justify-center gap-4">
                <button class="btn px-14 " @click="LogOut">Yes log me out <i class="bi bi-box-arrow-right text-xl"></i></button>
                <button class="btn px-14 bg-amber-950 text-white" @click="Cancel">Just Kidding <i class="bi bi-emoji-smile-fill text-white text-xl"></i></button>
            </div>
            <div />
        </div>
    </div>
</template>

<script setup>
import instance from '../api/agent.ts'
import { useUserStore } from '../stores/user'
import { useRouter } from 'vue-router'
const userStore = useUserStore()
const router = useRouter()
function LogOut() {
    userStore.clearUser()
    router.push('/');
}

function Cancel(){
    router.push('/dashboard')
}

</script>