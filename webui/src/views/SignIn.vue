<template>
  <div class="flex justify-center mt-24">
    <div class="card bg-base-100 image-full shadow-xl">
      <figure>
        <img src="../assets//images/book-img.png" alt="Shoes" />
      </figure>
      <div class="card-body content-center grid">
        <h1 class="text-justify text-6xl">Let's Share!!!</h1>
      </div>
    </div>
    <div class="border p-16 rounded-md shadow-xl">
      <h1 class="text-center text-4xl mb-6 text-amber-950">Sign In</h1>
      <form action="submit" method="post" class="mt-4">
        <label>
          Email
          <input
            type="email"
            placeholder="daisy@site.com"
            class="input input-bordered flex items-center gap-2 mb-6 grow" v-model="email"
          />
        </label>
        <label> Password </label>
        <input
          class="input input-bordered flex items-center gap-2 mb-8"
          type="password"
          placeholder="password" v-model="password"
        />
      </form>
      <button class="btn btn-block bg-amber-950 text-white text-2xl rounded-md mb-2" @click="loginUser(email, password)">Sign In</button>
      <RouterLink to="/dashboard">
      </RouterLink>
      <p>don't have an account? <RouterLink to="/signup" class="link">sign up</RouterLink></p>
    </div>
  </div>
</template>

<script setup>
import { ref } from 'vue'
import instance from '../api/agent.ts'
import { useUserStore } from '../stores/user'
import { useRouter } from 'vue-router'

const email = ref("")
const password = ref("")
const userStore = useUserStore()
const router = useRouter()

const loginUser = async (email, password) => {
  try {
    const response = await instance.post('User/login', { email, password });
    const userData = response.data;

    userStore.setUser(userData);
    userStore.setAccessToken(userData.token)

    console.log('User logged in:', userData.token);

    router.push('/dashboard');
  } catch (error) {
    console.error('Error logging in:', error);
  }
};
</script>
