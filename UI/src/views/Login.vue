<template>
  <!-- Fullscreen gradient wrapper -->
  <div class="login-wrap d-flex align-items-center justify-content-center">
    <div class="card login-card shadow-lg border-0">
      <div class="card-body p-4 p-md-5">
        <div class="text-center mb-4">
          <slot name="brand">
            <h2 class="fw-bold mb-1">Welcome back</h2>
            <p class="text-secondary mb-0">Sign in to continue</p>
          </slot>
        </div>

        <transition name="fade-slide">
          <div v-if="error" class="alert alert-danger" role="alert">{{ error }}</div>
        </transition>

        <form @submit.prevent="login" novalidate>
          <div class="form-floating mb-3">
            <input
              id="email"
              type="email"
              v-model.trim="email"
              class="form-control"
              :class="{ 'is-invalid': emailTouched && !isEmailValid }"
              placeholder="name@example.com"
              autocomplete="email"
              required
              @blur="emailTouched = true"
            />
            <label for="email">Email address</label>
            <div class="invalid-feedback">Please enter a valid email.</div>
          </div>

          <div class="mb-3 position-relative">
            <div class="form-floating">
              <input
                :type="showPassword ? 'text' : 'password'"
                id="password"
                v-model="password"
                class="form-control pe-5"
                :class="{ 'is-invalid': passwordTouched && !isPasswordValid }"
                placeholder="••••••••"
                autocomplete="current-password"
                minlength="6"
                required
                @blur="passwordTouched = true"
              />
              <label for="password">Password</label>
              <button
                type="button"
                class="btn btn-link password-toggle"
                @click="showPassword = !showPassword"
                :aria-label="showPassword ? 'Hide password' : 'Show password'"
              >
                <span v-if="showPassword">🙈</span>
                <span v-else>👁️</span>
              </button>
              <div class="invalid-feedback">Password must be at least 6 characters.</div>
            </div>
          </div>

          <div class="d-flex justify-content-between align-items-center mb-3">
            <div class="form-check">
              <input class="form-check-input" type="checkbox" id="remember" v-model="remember" />
              <label class="form-check-label" for="remember">Remember me</label>
            </div>
            <router-link class="small" to="/forgot-password">Forgot password?</router-link>
          </div>

          <button type="submit" class="btn btn-primary w-100 d-flex align-items-center justify-content-center gap-2" :disabled="loading || !formValid">
            <span v-if="loading" class="spinner-border spinner-border-sm" role="status" aria-hidden="true"></span>
            <span>{{ loading ? 'Signing in…' : 'Login' }}</span>
          </button>
        </form>

        <div class="text-center mt-4">
          <router-link to="/register">Don’t have an account? <strong>Create one</strong></router-link>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
import { ref, computed } from 'vue'
import axios from 'axios'
import { useRouter } from 'vue-router'

const router = useRouter()

const email = ref('')
const password = ref('')
const remember = ref(true)
const showPassword = ref(false)
const loading = ref(false)
const error = ref('')

const emailTouched = ref(false)
const passwordTouched = ref(false)

const isEmailValid = computed(() => /[^\s@]+@[^\s@]+\.[^\s@]+/.test(email.value))
const isPasswordValid = computed(() => (password.value?.length || 0) >= 6)
const formValid = computed(() => isEmailValid.value && isPasswordValid.value)

const login = async () => {
  error.value = ''
  emailTouched.value = true
  passwordTouched.value = true

  if (!formValid.value) return

  loading.value = true
  try {
    const response = await axios.post('http://localhost:5154/api/auth/login', {
      email: email.value,
      password: password.value
    })

    const token = response.data?.token
    if (!token) throw new Error('Invalid response')

    if (remember.value) {
      localStorage.setItem('token', token)
      localStorage.setItem('userEmail', email.value)
    } else {
      sessionStorage.setItem('token', token)
      sessionStorage.setItem('userEmail', email.value)
    }

    await router.push('/home')
  } catch (err) {
    const apiMsg = err?.response?.data?.message || err?.message
    error.value = apiMsg ? String(apiMsg) : 'Invalid credentials'
  } finally {
    loading.value = false
  }
}
</script>

<style scoped>
/* === FULLSCREEN COLORFUL BACKGROUND === */
.login-wrap {
  position: relative;
  width: 100vw;            /* ensure no side white spaces */
  min-height: 100vh;       /* full viewport height */
  overflow: hidden;        /* hide any decorative overflow */
  padding: 24px;           /* breathing room on small screens */

  display: flex;
  align-items: center;
  justify-content: center;

  /* animated multi‑stop gradient */
  background: linear-gradient(-45deg,
              #ff9a9e, #fad0c4,
              #a1c4fd, #c2e9fb,
              #d4fc79, #96e6a1,
              #fbc2eb, #a18cd1);
  background-size: 400% 400%;
  animation: gradientBG 16s ease infinite;
}

@keyframes gradientBG {
  0% { background-position: 0% 50%; }
  50% { background-position: 100% 50%; }
  100% { background-position: 0% 50%; }
}

/* === GLASSY CARD === */
.login-card {
  width: 100%;
  max-width: 420px;
  border-radius: 1rem;
  background: rgba(255, 255, 255, 0.9); /* keep readable on colorful bg */
  backdrop-filter: saturate(140%) blur(8px);
}

/* Inputs */
.form-control { border-radius: 0.75rem; }
.form-control:focus { box-shadow: 0 0 0 0.25rem rgba(13, 110, 253, 0.15); }

/* Password toggle icon */
.password-toggle {
  position: absolute;
  right: 0.5rem;
  top: 50%;
  transform: translateY(-50%);
  padding: 0.375rem 0.5rem;
  text-decoration: none;
}
.password-toggle:focus { outline: none; box-shadow: none; }

/* Smooth alert entrance */
.fade-slide-enter-active, .fade-slide-leave-active { transition: all 200ms ease; }
.fade-slide-enter-from { opacity: 0; transform: translateY(-6px); }
.fade-slide-leave-to { opacity: 0; transform: translateY(-6px); }
</style>
