<template>
  <div class="home-bg">
    <nav class="navbar">
      <div class="navbar-title">{{ userEmail }}</div>
      <button class="logout-btn" @click="logout">Logout</button>
    </nav>
    <div class="home-content">
      <EmployeeTable />
    </div>
    <footer class="home-footer">© Hadi Prasetyo 2016</footer>
  </div>
</template>

<script setup>
import { useRouter } from 'vue-router'
import EmployeeTable from '../components/EmployeeTable.vue'

const router = useRouter()
const userEmail = localStorage.getItem('userEmail') || 'User';
function logout() {
  localStorage.removeItem('token')
  localStorage.removeItem('userEmail')
  router.push('/login')
}
</script>
<style scoped>
.home-bg {
  background: #fff;
  min-height: 100vh;
  display: flex;
  flex-direction: column;
}
.navbar {
  background: #222;
  color: #fff;
  display: flex;
  align-items: center;
  padding: 0 32px;
  height: 56px;
  justify-content: space-between;
}
.navbar-title {
  font-size: 1.3rem;
  font-weight: 600;
  margin-right: 32px;
}
 .navbar-tabs {
  display: none;
}
.logout-btn {
  margin-left: auto;
  background: #f44336;
  color: #fff;
  border: none;
  border-radius: 4px;
  padding: 8px 20px;
  font-size: 1rem;
  font-weight: 500;
  cursor: pointer;
  transition: background 0.2s;
}
.logout-btn:hover {
  background: #d32f2f;
}
.home-content {
  flex: 1;
  padding: 32px;
}
.home-footer {
  text-align: center;
  color: #888;
  font-size: 1rem;
  padding: 16px 0 8px 0;
}
</style>