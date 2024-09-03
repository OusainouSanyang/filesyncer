import { defineStore } from 'pinia'
import { ref } from 'vue'

export const useUserStore = defineStore('user', () => {
  const user = ref(JSON.parse(localStorage.getItem('user') || 'null'))
  const token = ref(localStorage.getItem('token') || '')

  function setUser(userData:any) {
    user.value = userData
    localStorage.setItem('user', JSON.stringify(userData))
  }

  function setAccessToken(accessToken:any) {
    token.value = accessToken
    localStorage.setItem('token', accessToken)
  }

  function clearUser() {
    user.value = null
    token.value = ''
    localStorage.removeItem('user')
    localStorage.removeItem('token')
  }

  return {
    user,
    token,
    setUser,
    setAccessToken,
    clearUser
  }
})
