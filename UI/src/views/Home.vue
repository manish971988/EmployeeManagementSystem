<template>
  <div class="container mt-5">
    <div class="d-flex justify-content-between align-items-center mb-4">
      <h2>Home</h2>
      <button class="btn btn-danger" @click="logout">Logout</button>
    </div>
    <div>
      <EmployeeTable />
    </div>
  </div>
</template>

<script setup>
import { useRouter } from 'vue-router'
import EmployeeTable from '../components/EmployeeTable.vue'

const router = useRouter()

const logout = () => {
  localStorage.removeItem('token')
  router.push('/login')
}
</script>