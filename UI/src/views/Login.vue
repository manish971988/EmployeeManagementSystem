<template>
  <div class="container d-flex align-items-center justify-content-center min-vh-100">
    <div class="card p-4 shadow" style="max-width: 400px; width: 100%;">
      <h2 class="mb-4 text-center">Login</h2>
      <form @submit.prevent="login">
        <div class="mb-3">
          <label for="email" class="form-label">Email</label>
          <input type="email" v-model="email" class="form-control" required />
        </div>
        <div class="mb-3">
          <label for="password" class="form-label">Password</label>
          <input type="password" v-model="password" class="form-control" required />
        </div>
        <button type="submit" class="btn btn-primary w-100">Login</button>
      </form>
      <div v-if="error" class="alert alert-danger mt-3">{{ error }}</div>
      <div class="mt-3 text-center">
        <router-link to="/register">Don't have an account? Register</router-link>
      </div>
    </div>
  </div>
</template>

<script setup>

import { ref } from 'vue'
import axios from 'axios'
import { useRouter } from 'vue-router'

const email = ref('')
const password = ref('')
const error = ref('')
const router = useRouter()

const login = async () => {
  error.value = ''
  try {
    const response = await axios.post('http://localhost:5154/api/auth/login', {
      email: email.value,
      password: password.value
    })
    localStorage.setItem('token', response.data.token)
    localStorage.setItem('userEmail', email.value)
    router.push('/home')
  } catch (err) {
    error.value = 'Invalid credentials'
  }
}
</script>

<style scoped>
/* No custom styles needed, Bootstrap handles layout */
</style>
