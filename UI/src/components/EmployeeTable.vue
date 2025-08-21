<template>
    <div v-if="showToast" class="toast-container position-fixed top-0 end-0 p-3" style="z-index: 9999;">
      <div class="toast show align-items-center text-bg-success border-0" role="alert" aria-live="assertive" aria-atomic="true">
        <div class="d-flex">
          <div class="toast-body">
            Employee deleted successfully!
          </div>
          <button type="button" class="btn-close btn-close-white me-2 m-auto" @click="showToast = false"></button>
        </div>
      </div>
    </div>
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
          <th>Actions</th>
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
          <td>
            <button class="tool-btn edit" @click="editEmployee(emp)"><i class="fa fa-pencil"></i> Edit</button>
            <button class="tool-btn delete" @click="confirmDelete(emp)"><i class="fa fa-trash"></i> Delete</button>
          </td>
    <div v-if="showDeleteModal" class="modal fade show" tabindex="-1" style="display:block; background:rgba(0,0,0,0.5);">
      <div class="modal-dialog">
        <div class="modal-content">
          <div class="modal-header">
            <h5 class="modal-title">Confirm Delete</h5>
            <button type="button" class="btn-close" @click="showDeleteModal = false"></button>
          </div>
          <div class="modal-body">
            <p>Are you sure you want to delete employee <strong>{{ employeeToDelete?.name }}</strong>?</p>
          </div>
          <div class="modal-footer">
            <button type="button" class="btn btn-secondary" @click="showDeleteModal = false">Cancel</button>
            <button type="button" class="btn btn-danger" @click="deleteEmployee">Delete</button>
          </div>
        </div>
      </div>
    </div>
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
const showToast = ref(false)
const showDeleteModal = ref(false)
const employeeToDelete = ref(null)

function confirmDelete(emp) {
  employeeToDelete.value = emp
  showDeleteModal.value = true
}

async function deleteEmployee() {
  try {
    await axios.delete(`http://localhost:5154/api/employee/${employeeToDelete.value.id}`)
    employees.value = employees.value.filter(e => e.id !== employeeToDelete.value.id)
    showDeleteModal.value = false
    employeeToDelete.value = null
    showToast.value = true
    setTimeout(() => { showToast.value = false }, 2500)
  } catch (err) {
    // handle error or show message
    showDeleteModal.value = false
  }
}
import { ref, computed, onMounted } from 'vue'
import axios from 'axios'
import { useRouter } from 'vue-router'

const router = useRouter()

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

function editEmployee(emp) {
  router.push({ path: '/add-employee', query: { id: emp.id } })
}
</script>
