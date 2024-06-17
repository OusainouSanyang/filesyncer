<script setup lang="ts">
import AuthenticationForm from '../components/forms/AuthenticationForm.vue'
import FormImage from '../components/forms/FormImage.vue'
</script>

<template>
  <AuthenticationForm>
    <template v-slot:heading>
      Sign Up
    </template>

    <template v-slot:form>
      <div class="mb-3">
        <label for="username" class="form-label">First name</label>
        <input type="text" class="form-control" id="username" value="" required />
      </div>
      <div class="mb-3">
        <label for="" class="form-label">Email</label>
        <input type="email" class="form-control" name="" id="" aria-describedby="emailHelpId"
          placeholder="abc@mail.com" />

      </div>
      <div class="mb-3">
        <label for="" class="form-label">Password</label>
        <input type="password" class="form-control" name="" id="" placeholder="" />
        <small id="emailHelpId" class="form-text text-muted">Help text</small>
      </div>
      <div class="mb-3">
        <label for="" class="form-label"> Confirm Password</label>
        <input type="password" class="form-control" name="" id="" placeholder="" />
      </div>
    </template>
    <template v-slot:button>
      Create Account
    </template>
  </AuthenticationForm>
  <FormImage/>
</template>
