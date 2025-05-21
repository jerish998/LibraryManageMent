<template>
  <form >
    <div>
<div>
    <h1>REGISTER</h1>
</div>
<div>
    <form @submit.prevent="handleSubmit">
    <div class="form-group">
        <label for="name">Name:</label>
        <input type="text" id="name" v-model="name">
    </div>
    <div class="form-group">
        <label for="email">Email:</label>
        <input type="email" id="email" v-model="email">
    </div>
    <div class="form-group">
        <label for="name">Password:</label>
        <input type="password" id="password" v-model="password">
    </div>
    <button type="submit">Sign Up</button>
    </form>
</div>

    </div>
    
  </form>
</template>

<script>
export default{
methods:{

async handleSubmit(){
    console.log("Handele click");
}


}
}
</script>