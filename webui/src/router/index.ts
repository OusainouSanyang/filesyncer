import { createRouter, createWebHistory } from 'vue-router'
import SignIn from '@/views/SignIn.vue'
import SignUp from '@/views/SignUp.vue'
import Dashboard from '@/components/Dashboard.vue'
import MyDocs from '@/components/MyDocs.vue'
import LogOut from '@/components/LogOut.vue'
import HomeView from '@/views/HomeView.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'signin',
      component: SignIn
    },
    {
      path: '/signup',
      name: 'signup',
      component: SignUp
    },
    {
      path: '/home',
      name: 'home',
      component: HomeView,
      children: [
        {
          path: '/dashboard',
          name: 'dashboard',
          component: Dashboard
        },
        {
          path: '/my-documents',
          name: 'documents',
          component: MyDocs
        },
        {
          path: '/log-out',
          name: 'logout',
          component: LogOut
        }
      ]
    },
  ]
})

export default router
