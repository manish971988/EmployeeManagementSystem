<template>
  <div>
    <h4>Employee List</h4>
    <input v-model="search" class="form-control mb-3" placeholder="Search by name or email" />
    <table class="table table-bordered table-hover">
      <thead>
        <tr>
          <th @click="sort('id')">ID</th>
          <th @click="sort('name')">Name</th>
          <th @click="sort('email')">Email</th>
          <th @click="sort('designation')">Designation</th>
          <th @click="sort('department')">Department</th>
          <th @click="sort('joiningDate')">Joining Date</th>
          <th @click="sort('salary')">Salary</th>
        </tr>
      </thead>
      <tbody>
        <tr v-for="emp in paginatedEmployees" :key="emp.id">
          <td>{{ emp.id }}</td>
          <td>{{ emp.name }}</td>
          <td>{{ emp.email }}</td>
          <td>{{ emp.designation }}</td>
          <td>{{ emp.department }}</td>
          <td>{{ emp.joiningDate }}</td>
          <td>{{ emp.salary }}</td>
        </tr>
      </tbody>
    </table>
    <nav>
      <ul class="pagination justify-content-center">
        <li class="page-item" :class="{ disabled: page === 1 }">
          <button class="page-link" @click="page--" :disabled="page === 1">Previous</button>
        </li>
        <li class="page-item" v-for="p in totalPages" :key="p" :class="{ active: p === page }">
          <button class="page-link" @click="page = p">{{ p }}</button>
        </li>
        <li class="page-item" :class="{ disabled: page === totalPages }">
          <button class="page-link" @click="page++" :disabled="page === totalPages">Next</button>
        </li>
      </ul>
    </nav>
  </div>
</template>

<script setup>
import { ref, computed, onMounted } from 'vue'
import axios from 'axios'

const employees = ref([])

onMounted(async () => {
  try {
    const response = await axios.get('http://localhost:5154/api/employee')
    employees.value = response.data
  } catch (err) {
    // handle error or show message
  }
})

const search = ref('')
const sortKey = ref('id')
const sortAsc = ref(true)
const page = ref(1)
const pageSize = 5

const filteredEmployees = computed(() => {
  let result = employees.value.filter(emp =>
    emp.name.toLowerCase().includes(search.value.toLowerCase()) ||
    emp.email.toLowerCase().includes(search.value.toLowerCase())
  )
  result = result.sort((a, b) => {
    if (a[sortKey.value] < b[sortKey.value]) return sortAsc.value ? -1 : 1
    if (a[sortKey.value] > b[sortKey.value]) return sortAsc.value ? 1 : -1
    return 0
  })
  return result
})

const totalPages = computed(() => Math.ceil(filteredEmployees.value.length / pageSize))
const paginatedEmployees = computed(() => {
  const start = (page.value - 1) * pageSize
  return filteredEmployees.value.slice(start, start + pageSize)
})

function sort(key) {
  if (sortKey.value === key) {
    sortAsc.value = !sortAsc.value
  } else {
    sortKey.value = key
    sortAsc.value = true
  }
}
</script>
