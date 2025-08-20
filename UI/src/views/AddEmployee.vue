<template>
  <div class="add-employee-bg">
    <div class="add-employee-card">
      <h2>Add Employee</h2>
      <form @submit.prevent="submitForm">
        <div class="form-group">
          <label>Name</label>
          <input v-model="form.name" type="text" required />
        </div>
        <div class="form-group">
          <label>Email</label>
          <input v-model="form.email" type="email" required />
        </div>
        <div class="form-group">
          <label>Designation</label>
          <input v-model="form.designation" type="text" required />
        </div>
        <div class="form-group">
          <label>Department</label>
          <input v-model="form.department" type="text" required />
        </div>
        <div class="form-group">
          <label>Joining Date</label>
          <input v-model="form.joiningDate" type="date" required />
        </div>
        <div class="form-group">
          <label>Salary</label>
          <input v-model="form.salary" type="number" min="0.01" step="0.01" required />
        </div>
        <div class="form-actions">
          <button type="submit" class="save-btn">Save</button>
          <button type="button" class="cancel-btn" @click="cancel">Cancel</button>
        </div>
        <div v-if="error" class="form-error">{{ error }}</div>
      </form>
    </div>
  </div>
</template>

<script setup>
import { ref } from 'vue';
import { useRouter } from 'vue-router';
import axios from 'axios';

const router = useRouter();
const error = ref('');
const today = new Date().toISOString().slice(0, 10);
const form = ref({
  name: '',
  email: '',
  designation: '',
  department: '',
  joiningDate: today,
  salary: ''
});

function validateForm() {
  if (!form.value.name || !form.value.email || !form.value.designation || !form.value.department || !form.value.joiningDate || !form.value.salary) {
    error.value = 'All fields are required.';
    return false;
  }
  // Simple email validation
  const emailRegex = /^[^@\s]+@[^@\s]+\.[^@\s]+$/;
  if (!emailRegex.test(form.value.email)) {
    error.value = 'Please enter a valid email.';
    return false;
  }
  if (parseFloat(form.value.salary) <= 0) {
    error.value = 'Salary must be greater than 0.';
    return false;
  }
  error.value = '';
  return true;
}

async function submitForm() {
  if (!validateForm()) return;
  try {
    await axios.post('http://localhost:5154/api/employee', form.value);
    router.push('/home');
  } catch (err) {
    error.value = 'Failed to add employee.';
  }
}

function cancel() {
  router.push('/home');
}
</script>

<style scoped>
.add-employee-bg {
  min-height: 100vh;
  background: #f3f3f3;
  display: flex;
  align-items: center;
  justify-content: center;
}
.add-employee-card {
  background: #fff;
  border-radius: 12px;
  box-shadow: 0 2px 16px rgba(0,0,0,0.08);
  width: 400px;
  max-width: 90vw;
  padding: 32px 32px 24px 32px;
}
.form-group {
  margin-bottom: 18px;
  display: flex;
  flex-direction: column;
}
.form-group label {
  font-weight: 500;
  margin-bottom: 6px;
}
.form-group input {
  border: 1px solid #e0e0e0;
  border-radius: 4px;
  padding: 8px;
  font-size: 1rem;
}
.form-actions {
  display: flex;
  justify-content: space-between;
  margin-top: 18px;
}
.save-btn {
  background: #21c87a;
  color: #fff;
  border: none;
  border-radius: 4px;
  padding: 10px 24px;
  font-size: 1rem;
  font-weight: 500;
  cursor: pointer;
  transition: background 0.2s;
}
.save-btn:hover {
  background: #17a864;
}
.cancel-btn {
  background: #f44336;
  color: #fff;
  border: none;
  border-radius: 4px;
  padding: 10px 24px;
  font-size: 1rem;
  font-weight: 500;
  cursor: pointer;
  transition: background 0.2s;
}
.cancel-btn:hover {
  background: #d32f2f;
}
.form-error {
  color: #d9534f;
  text-align: center;
  margin-top: 12px;
}
</style>
