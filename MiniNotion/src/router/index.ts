import { createRouter, createWebHistory } from 'vue-router'
import HomeView from '../views/HomeView.vue'
import Pages from '@/views/Pages.vue'
// import Blocks from '@/views/Blocks.vue'

const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: '/',
      name: 'home',
      component: HomeView,
    },
    {
      path: '/about',
      name: 'about',
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import('../views/AboutView.vue'),
    },
    {
      path: '/pages',
      name: 'pages',
      component: Pages,
    },
     /*{
      path: '/blocks',
      name: 'blocks',
      component: Blocks,
    }, */
  ],
})

export default router
