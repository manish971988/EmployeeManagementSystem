import { createRouter, createWebHistory } from 'vue-router'
import Login from './views/Login.vue'
import Register from './views/Register.vue'
import Home from './views/Home.vue'
import EmployeeList from './views/EmployeeList.vue'
import AddEmployee from './views/AddEmployee.vue'

const routes = [
  { path: '/', redirect: '/login' },
  { path: '/login', component: Login },
  { path: '/register', component: Register },
  { path: '/home', component: Home },
  { path: '/add-employee', component: AddEmployee },
]

const router = createRouter({
  history: createWebHistory(),
  routes,
})

export default router
