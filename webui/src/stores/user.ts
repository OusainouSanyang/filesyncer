import { defineStore } from 'pinia'
import { ref } from 'vue'

export const useUserStore = defineStore('user', () => {
  const user = ref(null)

  // Function to set the user data
  const setUser = (userData: any) => {
    user.value = userData
  }

  
  return { user, setUser,}
})
